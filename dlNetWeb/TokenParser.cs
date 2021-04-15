using dlNetWeb.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb
{
    public class TokenParser
    {
        private readonly ISharedState _sharedState;

        public TokenParser(ISharedState sharedState)
        {
            _sharedState = sharedState;
            _sharedState.RegisterTokenEmitListener(TokenEmitListener);
        }

        // TODO: https://html.spec.whatwg.org/multipage/parsing.html#tree-construction
        private bool TokenEmitListener(Tokens.BaseToken token)
        {

            return false;
        }
    }
}
