using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public abstract class BaseHandler<T> where T : Tokens.BaseToken
    {
        public event EventHandler<Tokens.BaseToken> EmitToken;

        internal T token;
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

        public void Run()
        {
            OnRun();
        }

        internal virtual void OnRun() { }

        internal void OnEmitToken(Tokens.BaseToken token)
        {
            EmitToken.Invoke(this, token);
        }
    }
}
