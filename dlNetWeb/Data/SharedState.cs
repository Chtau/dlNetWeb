using dlNetWeb.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Data
{
    public class SharedState : ISharedState
    {
        public State State { get; set; } = State.Data;
        public State ReturnState { get; set; } = State.Data;
        public Tokens.BaseToken Token { get; set; }
        public ParseError Error { get; set; } = ParseError.None;
        public string TemporaryBuffer { get; set; } = null;
        public List<Tokens.BaseToken> Tokens { get; set; } = new List<BaseToken>();
        public Int32 CharacterReferenceCode { get; set; }
        public InsertionMode InsertionMode { get; set; } = InsertionMode.Initial;

        private Func<Tokens.BaseToken, bool> callbackListenerAction;
        public bool EmitToken(Tokens.BaseToken token)
        {
            if (callbackListenerAction != null)
                return callbackListenerAction.Invoke(token);
            return false;
        }

        public void RegisterTokenEmitListener(Func<Tokens.BaseToken, bool> listenerAction)
        {
            callbackListenerAction = listenerAction;
        }
    }
}
