using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TreeHandler
{
    public abstract class BaseHandler
    {
        public bool Run(Tokens.BaseToken token)
        {
            return OnRun(token);
        }

        internal virtual bool OnRun(Tokens.BaseToken token) { return false; }
    }
}
