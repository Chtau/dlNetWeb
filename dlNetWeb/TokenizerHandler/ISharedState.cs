using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public interface ISharedState
    {
        public Tokens.State State { get; set; }
        public Tokens.State ReturnState { get; set; }
        public Tokens.BaseToken Token { get; set; }
        public ParseError Error { get; set; }
        public string TemporaryBuffer { get; set; }
        public List<Tokens.BaseToken> Tokens { get; set; }
        public Int32 CharacterReferenceCode { get; set; }
    }
}
