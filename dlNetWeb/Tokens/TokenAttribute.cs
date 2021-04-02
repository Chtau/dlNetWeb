using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Tokens
{
    public class TokenAttribute
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public TokenAttribute()
        {
            Name = null;
            Value = null;
        }

        public TokenAttribute(string name, string value) : this()
        {
            Name = name;
            Value = value;
        }
    }
}
