using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Tokens
{
    public class DOCTYPEToken : BaseToken
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string SystemIdentifier { get; set; }
        public bool ForceQuirks { get; set; }

        public DOCTYPEToken()
        {
            // null is missing state which is a distinct state from empty string
            Name = null;
            Identifier = null;
            SystemIdentifier = null;
            ForceQuirks = false;
        }
    }
}
