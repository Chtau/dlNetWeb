using dlNetWeb.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TreeHandler
{
    public class TreeDispatchHandler : BaseHandler
    {
        internal override bool OnRun(BaseToken token)
        {
            base.OnRun(token);

            return false;
        }
    }
}
