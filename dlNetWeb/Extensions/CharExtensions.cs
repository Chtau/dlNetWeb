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

        public static bool IsLetterLower(this ReadOnlyMemory<char> memoryChar)
        {
            var charSpan = memoryChar.Span[0];
            return Char.IsLetter(charSpan) && Char.IsLower(charSpan);
        }

        public static bool IsLetterOrDigit(this ReadOnlyMemory<char> memoryChar)
        {
            return char.IsLetterOrDigit(memoryChar.Span[0]);
        }

        public static bool IsLetter(this ReadOnlyMemory<char> memoryChar)
        {
            return Char.IsLetter(memoryChar.Span[0]);
        }

        public static Int32 ToDigit(this ReadOnlyMemory<char> memoryChar)
        {
            return Int32.Parse(memoryChar.Span[0].ToString());
        }

        public static bool UpperHexDigit(this ReadOnlyMemory<char> memoryChar)
        {
            return memoryChar.Span[0] >= '\u0041' && memoryChar.Span[0] <= '\u0046';
        }

        public static bool LowerHexDigit(this ReadOnlyMemory<char> memoryChar)
        {
            return memoryChar.Span[0] >= '\u0061' && memoryChar.Span[0] <= '\u0066';
        }

        public static bool Alpha(this ReadOnlyMemory<char> memoryChar)
        {
            return memoryChar.UpperAlpha() || memoryChar.LowerAlpha();
        }

        public static bool UpperAlpha(this ReadOnlyMemory<char> memoryChar)
        {
            return memoryChar.Span[0] >= '\u0041' && memoryChar.Span[0] <= '\u005A';
        }

        public static bool LowerAlpha(this ReadOnlyMemory<char> memoryChar)
        {
            return memoryChar.Span[0] >= '\u0061' && memoryChar.Span[0] <= '\u007A';
        }

        public static bool Digit(this ReadOnlyMemory<char> memoryChar)
        {
            return memoryChar.Span[0] >= '\u0030' && memoryChar.Span[0] <= '\u0039';
        }

        public static bool Alphanumeric(this ReadOnlyMemory<char> memoryChar)
        {
            return memoryChar.Alpha() || memoryChar.Digit();
        }

        public static int Hex(this ReadOnlyMemory<char> memoryChar)
        {
            return Int32.Parse(memoryChar.Span[0].ToString(), System.Globalization.NumberStyles.HexNumber);
        }

        public static bool IsSurrogate(this ReadOnlyMemory<char> memoryChar)
        {
            return Char.IsSurrogate(memoryChar.Span[0]);
        }

        public static bool IsSurrogate(this Int32 value)
        {
            return Char.IsSurrogate((Char)value);
        }

        public static bool IsNonCharacter(this Int32 value)
        {
            var charVal = (Char)value;
            var compare = new List<char>
            {
                '\uFDD0',
                '\uFDEF',
                '\uFFFE',
                '\uFFFF'
            };
            var compareString = new List<string>
            {
                "\uD83F\uDFFE",
                "\uD83F\uDFFF",
                "\uD87F\uDFFE",
                "\uD87F\uDFFF",
                "\uD8BF\uDFFE",
                "\uD8BF\uDFFF",
                "\uD8FF\uDFFE",
                "\uD8FF\uDFFF",
                "\uD93F\uDFFE",
                "\uD93F\uDFFF",
                "\uD97F\uDFFE",
                "\uD97F\uDFFF",
                "\uD9BF\uDFFE",
                "\uD9BF\uDFFF",
                "\uD9FF\uDFFE",
                "\uD9FF\uDFFF",
                "\uDA3F\uDFFE",
                "\uDA3F\uDFFF",
                "\uDA7F\uDFFE",
                "\uDA7F\uDFFF",
                "\uDABF\uDFFE",
                "\uDABF\uDFFF",
                "\uDAFF\uDFFE",
                "\uDAFF\uDFFF",
                "\uDB3F\uDFFE",
                "\uDB3F\uDFFF",
                "\uDB7F\uDFFE",
                "\uDB7F\uDFFF",
                "\uDBBF\uDFFE",
                "\uDBBF\uDFFF",
                "\uDBFF\uDFFE",
                "\uDBFF\uDFFF"
            };
            // TODO: https://infra.spec.whatwg.org/#noncharacter
            return compare.Contains(charVal)
                || (charVal >= '\uFDD0' && charVal <= '\uFDEF')
                || compareString.Contains(charVal.ToString());
        }

        public static bool IsAsciiWhitespace(this Int32 value)
        {
            var charVal = (Char)value;
            var compare = new List<char>
            {
                '\u0009',
                '\u000A',
                '\u000C',
                '\u000D',
                '\u0020'
            };
            return compare.Contains(charVal);
        }

        public static bool IsAsciiWhitespace(this ReadOnlyMemory<char> memoryChar)
        {
            var compare = new List<char>
            {
                '\u0009',
                '\u000A',
                '\u000C',
                '\u000D',
                '\u0020'
            };
            return compare.Contains(memoryChar.Span[0]);
        }

        public static bool IsControlCodepoint(this Int32 value)
        {
            var charVal = (Char)value;
            return (charVal >= '\u007F' && charVal <= '\u009F');
        }
    }
}