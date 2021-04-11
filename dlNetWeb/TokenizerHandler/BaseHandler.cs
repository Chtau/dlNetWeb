using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public abstract class BaseHandler<T> where T : Tokens.BaseToken
    {
        public event EventHandler<Tokens.BaseToken> EmitToken;

        internal T Token
        {
            get { return (T)state.Token; }
            set { state.Token = value; }
        }
        internal IDataSource data;
        internal Helper.ILogger log;
        internal ISharedState state;
        internal string temporaryBuffer = null;

        public void Initialize(IDataSource dataSource, Helper.ILogger logger, ISharedState sharedState)
        {
            data = dataSource;
            log = logger;
            state = sharedState;
        }

        public bool Run()
        {
            return OnRun();
        }

        internal virtual bool OnRun() { return false; }

        internal void OnEmitToken(Tokens.BaseToken token)
        {
            EmitToken.Invoke(this, token);
        }
    }
}
