using dlNetWeb.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class SharedState : ISharedState
    {
        public State State { get; set; } = State.Data;
        public State ReturnState { get; set; } = State.Data;
        public Tokens.BaseToken Token { get; set; }
    }
}
