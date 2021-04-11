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
    }
}
