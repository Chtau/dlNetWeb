using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Tokens
{
    public class BaseTagToken : BaseToken
    {
        public string TagName { get; set; }
        public bool SelfClosing { get; set; } = false;
        public List<TokenAttribute> Attributes { get; set; } = new List<TokenAttribute>();
    }
}
