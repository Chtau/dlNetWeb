using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Tokens
{
    public abstract class BaseToken
    {
        public State State { get; set; } = State.Data;
        public State ReturnState { get; set; } = State.Data;
        public string Value { get; set; }
        public string TemporaryBuffer { get; set; } = string.Empty;
        public bool Acknowledged { get; set; } = false;
    }
}
