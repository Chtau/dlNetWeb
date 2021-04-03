using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb
{
    public class Tokenizer
    {
        public bool ParserPause { get; set; }
        private readonly string _content;
        private int readPosition;

        private Tokens.State state = Tokens.State.Data;
        private Tokens.State returnState = Tokens.State.Data;

        public Tokenizer(string content)
        {
            _content = content;
        }

        public void Run()
        {
            var currentInputCharacter = OnNextChar(readPosition);
            switch (state)
            {
                case Tokens.State.Data:
                    if (!currentInputCharacter.IsEmpty)
                    {
                        if (currentInputCharacter[0] == '&')
                        {
                            var returnState = Tokens.State.Data;
                            // Switch state to CharacterReference
                        }
                        else if (currentInputCharacter[0] == '<')
                        {
                            // Switch state to TagOpen
                        }
                    }
                    break;
                case Tokens.State.TagOpen:
                    if (!currentInputCharacter.IsEmpty)
                    {
                        if (currentInputCharacter[0] == '!')
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

        private ReadOnlySpan<char> OnNextChar(int start, int length = 1)
        {
            if (string.IsNullOrWhiteSpace(_content))
                return ReadOnlySpan<char>.Empty;
            return _content.AsSpan().Slice(start, length);
        }
    }
}
