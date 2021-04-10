using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace dlNetWeb.Extensions
{
    public static class CharExtensions
    {
        private readonly static Regex alphanumericRegex = new Regex(@"^[a-zA-Z0-9\s,]*$");

        public static bool IsAlphaNumeric(this char character)
        {
            return alphanumericRegex.IsMatch(character.ToString());
        }
    }
}
