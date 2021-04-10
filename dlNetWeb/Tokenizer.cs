using System;
using System.Collections.Generic;
using System.Text;
using dlNetWeb.Extensions;

namespace dlNetWeb
{
    public class Tokenizer
    {
        public event EventHandler<Tokens.BaseToken> EmitToken;

        private readonly Data.NamedCharacterReferenceData _namedCharacterReference = new Data.NamedCharacterReferenceData();

        private ReadOnlyMemory<char> _memory;
        private int readPosition = 0;

        private Tokens.State state = Tokens.State.Data;
        private Tokens.State returnState = Tokens.State.Data;
        private string temporaryBuffer = null;
        private bool consumeAsAttribute = false;
        private Tokens.BaseToken currentToken;

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
                        currentInputCharacter = OnNextChar(readPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0].IsAlphaNumeric())
                            {
                                // Reconsume in the named character reference state.
                                state = Tokens.State.NamedCharacterReference;
                            } else if (currentInputCharacter.Span[0] == '#')
                            {
                                temporaryBuffer += currentInputCharacter.Span[0];
                                state = Tokens.State.NumericCharacterReference;
                                break;
                            } else
                            {
                                readPosition--;
                                state = returnState;
                                break;
                            }
                        }
                        else
                        {
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.NamedCharacterReference:
                        string namedChar = string.Empty + currentInputCharacter.Span[0];
                        //temporaryBuffer += namedChar;
                        if (!consumeAsAttribute)
                        {
                            // peak till no match for a key in _namedCharacterReference
                            string matchKey = null;
                            for (int i = 1; i < _namedCharacterReference.MaxKeyLength; i++)
                            {
                                var match = _namedCharacterReference.HasMatchingKeys(namedChar);
                                if (string.IsNullOrWhiteSpace(match))
                                    break;
                                else
                                {
                                    matchKey = match;
                                    namedChar += OnNextChar(readPosition + 1, 1 + i);
                                }
                            }
                            if (matchKey.Length > 0)
                            {
                                if (matchKey[^1] != ';')
                                {
                                    // set parse error for "missing-semicolon-after-character-reference"
                                }
                                // append characters from key to buffer
                                temporaryBuffer += _namedCharacterReference.Entities[matchKey].Characters;
                                // mark as consumed
                                readPosition += matchKey.Length - 1; // -1 because & was already consumed
                                state = returnState;
                                break;
                            } else
                            {
                                temporaryBuffer += currentInputCharacter.Span[0];
                                state = Tokens.State.AmbiguousAmpersand;
                                break;
                            }
                        }
                        break;
                    case Tokens.State.AmbiguousAmpersand:
                        currentInputCharacter = OnNextChar(readPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0].IsAlphaNumeric())
                            {
                                EmitToken?.Invoke(this, new Tokens.CharacterToken
                                {
                                    Value = currentInputCharacter.ToString()
                                });
                                break;
                            } else if (currentInputCharacter.Span[0] == ';')
                            {
                                // parse error for "unknown-named-character-reference"
                            }
                            state = returnState;
                            readPosition--; // reconsume in return
                            break;
                        }
                        else
                        {
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.NumericCharacterReference:
                        if (Char.IsLetter(currentInputCharacter.Span[0]))
                        {
                            temporaryBuffer += currentInputCharacter.Span[0];
                            state = Tokens.State.HexadecimalCharacterReferenceStart;
                            break;
                        } else
                        {
                            state = Tokens.State.DecimalCharacterReferenceStart;
                            readPosition--;
                            break;
                        }
                    case Tokens.State.HexadecimalCharacterReferenceStart:
                        currentInputCharacter = OnNextChar(readPosition++);
                        if (Char.IsLetter(currentInputCharacter.Span[0]))
                        {
                            state = Tokens.State.HexadecimalCharacterReference;
                            readPosition--;
                            break;
                        } else
                        {
                            //  parse error for "absence-of-digits-in-numeric-character-reference"
                            state = returnState;
                            readPosition--;
                            break;
                        }
                    case Tokens.State.DecimalCharacterReferenceStart:
                        currentInputCharacter = OnNextChar(readPosition++);
                        if (Char.IsDigit(currentInputCharacter.Span[0]))
                        {
                            state = Tokens.State.DecimalCharacterReference;
                            readPosition--;
                            break;
                        } else
                        {
                            // parse error for "absence-of-digits-in-numeric-character-reference"
                            state = returnState;
                            readPosition--;
                            break;
                        }
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
