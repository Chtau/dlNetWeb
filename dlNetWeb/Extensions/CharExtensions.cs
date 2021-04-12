using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace dlNetWeb.Extensions
{
    public static class CharExtensions
    {
        private readonly static Regex alphanumericRegex = new Regex(@"^[a-zA-Z0-9\s,]*$");

        public static bool IsAlphaNumeric(this char character)
        {
            return Char.IsLetterOrDigit(character);
            //return alphanumericRegex.IsMatch(character.ToString());
        }

        public static bool AnyOf(this ReadOnlyMemory<char> memoryChar, params char[] characters)
        {
            return characters.Contains(memoryChar.Span[0]);
        }

        public static bool IsLetterUpper(this ReadOnlyMemory<char> memoryChar)
        {
            var charSpan = memoryChar.Span[0];
            return Char.IsLetter(charSpan) && Char.IsUpper(charSpan);
        }

        public static bool IsLetterOrDigit(this ReadOnlyMemory<char> memoryChar)
        {
            return char.IsLetterOrDigit(memoryChar.Span[0]);
        }

        public static bool IsLetter(this ReadOnlyMemory<char> memoryChar)
        {
            return Char.IsLetter(memoryChar.Span[0]);
        }

        public static bool IsDigit(this ReadOnlyMemory<char> memoryChar)
        {
            return Char.IsDigit(memoryChar.Span[0]);
        }
    }
}
