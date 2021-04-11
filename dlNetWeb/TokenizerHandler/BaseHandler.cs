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
        }
    }
}
