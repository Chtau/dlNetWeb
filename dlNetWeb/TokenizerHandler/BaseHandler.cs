using dlNetWeb.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public abstract class BaseHandler<T> where T : Tokens.BaseToken
    {
        internal T Token
        {
            get { return (T)state.Token; }
            set { state.Token = value; }
        }
        internal IDataSource data;
        internal Helper.ILogger log;
        internal ISharedState state;
        internal string temporaryBuffer = null;

        private Action<Tokens.BaseToken> tokenCallback;

        public void Initialize(IDataSource dataSource, Helper.ILogger logger, ISharedState sharedState, Action<Tokens.BaseToken> tokenCallback)
        {
            data = dataSource;
            log = logger;
            state = sharedState;
            this.tokenCallback = tokenCallback;
        }

        public bool Run()
        {
            return OnRun();
        }

        internal virtual bool OnRun() { return false; }

        internal void OnEmitToken(Tokens.BaseToken token)
        {
            tokenCallback.Invoke(token);
            state.Tokens.Add(token);
            state.EmitToken(token);
        }

        internal void OnChangeState(Tokens.State eState)
        {
            state.State = eState;
        }

        internal void OnSetParseError(ParseError parseError)
        {
            state.Error = parseError;
        }

        internal Tokens.BaseToken GetLastToken()
        {
            if (state.Tokens.Count > 0)
                return state.Tokens[^1];
            return null;
        }

        internal bool OnHasAppropriateEndTagToken(string tagName)
        {
            var token = state.Tokens.FindLast(x =>
            {
                if (x is Tokens.StartTagToken token && token.TagName == tagName)
                {
                    return true;
                }
                else
                    return false;
            });
            return token != null;
        }

        internal void OnFlushCodePoints()
        {
            if (state.TemporaryBuffer?.Length > 0)
            {
                foreach (var temp in state.TemporaryBuffer)
                {
                    OnEmitToken(new Tokens.CharacterToken { Value = temp.ToString() });
                }
            }
        }

        internal bool OnIsPartOfAttribute()
        {
            if (state.ReturnState == Tokens.State.AttributeValueDoubleQuoted
                                    || state.ReturnState == Tokens.State.AttributeValueSingleQuoted
                                    || state.ReturnState == Tokens.State.AttributeValueUnquoted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool OnIsAdjustedCurrentNode()
        {
            // TODO: https://html.spec.whatwg.org/multipage/parsing.html#adjusted-current-node
            return true;
        }
    }
}
