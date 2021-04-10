using System;
using System.Collections.Generic;
using System.Text;
using dlNetWeb.Extensions;

namespace dlNetWeb
{
    public class Tokenizer
    {
        public bool ParserPause { get; set; }
        private ReadOnlyMemory<char> _memory;
        private int readPosition = 0;

        private Tokens.State state = Tokens.State.Data;
        private Tokens.State returnState = Tokens.State.Data;
        private string temporaryBuffer = null;

        public Tokenizer(string content)
        {
            _memory = content?.AsMemory() ?? ReadOnlyMemory<char>.Empty;
        }

        public void Run()
        {
            bool exitLoop = false;
            ReadOnlyMemory<char> currentInputCharacter = ReadOnlyMemory<char>.Empty;
            do
            {
                switch (state)
                {
                    case Tokens.State.Data:
                        currentInputCharacter = OnNextChar(readPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '&')
                            {
                                returnState = Tokens.State.Data;
                                // Switch state to CharacterReference
                                state = Tokens.State.CharacterReference;
                                break;
                            }
                            else if (currentInputCharacter.Span[0] == '<')
                            {
                                // Switch state to TagOpen
                            }
                        } else
                        {
                            exitLoop = true;
                        }
                        break;
                    /*case Tokens.State.TagOpen:
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '!')
                            {
                                // Switch state to Markup
                            }
                        }
                    break;
                case Tokens.State.MarkupDeclarationOpen:
                    // peak ahead for "DOCTYPE"
                    break;*/
                    case Tokens.State.CharacterReference:
                        temporaryBuffer = string.Empty;
                        temporaryBuffer += '&';
                        currentInputCharacter = OnNextChar(readPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0].IsAlphaNumeric())
                            {
                                // Reconsume in the named character reference state.
                                state = Tokens.State.NamedCharacterReference;
                            }
                        }
                        else
                        {
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.NamedCharacterReference:
                        temporaryBuffer += currentInputCharacter.Span[0];
                        break;
                    default:
                        break;
                }
            } while (!exitLoop);
        }

        private ReadOnlyMemory<char> OnNextChar(int start, int length = 1)
        {
            if (_memory.IsEmpty)
                return ReadOnlyMemory<char>.Empty;
            return _memory.Slice(start, length);
        }
    }
}
