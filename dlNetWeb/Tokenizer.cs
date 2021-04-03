using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb
{
    public class Tokenizer
    {
        public bool ParserPause { get; set; }
        private ReadOnlyMemory<char> _memory;
        private int readPosition;

        private Tokens.State state = Tokens.State.Data;
        private Tokens.State returnState = Tokens.State.Data;

        public Tokenizer(string content)
        {
            _memory = content?.AsMemory() ?? ReadOnlyMemory<char>.Empty;
        }

        public void Run()
        {
            var currentInputCharacter = OnNextChar(readPosition);
            switch (state)
            {
                case Tokens.State.Data:
                    if (!currentInputCharacter.IsEmpty)
                    {
                        if (currentInputCharacter.Span[0] == '&')
                        {
                            var returnState = Tokens.State.Data;
                            // Switch state to CharacterReference
                        }
                        else if (currentInputCharacter.Span[0] == '<')
                        {
                            // Switch state to TagOpen
                        }
                    }
                    break;
                case Tokens.State.TagOpen:
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
                    break;
                default:
                    break;
            }
        }

        private ReadOnlyMemory<char> OnNextChar(int start, int length = 1)
        {
            if (_memory.IsEmpty)
                return ReadOnlyMemory<char>.Empty;
            return _memory.Slice(start, length);
        }
    }
}
