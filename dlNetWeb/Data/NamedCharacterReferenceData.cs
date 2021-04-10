using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dlNetWeb.Data
{
    /// <summary>
    /// Source from https://html.spec.whatwg.org/multipage/named-characters.html#named-character-references
    /// </summary>
    public class NamedCharacterReferenceData
    {
        public int MaxKeyLength { get; }

        public Dictionary<string, Models.NamedCharacterReferenceCodepointModel> Entities { get; set; } = new Dictionary<string, Models.NamedCharacterReferenceCodepointModel>();

        public NamedCharacterReferenceData()
        {
            Entities.Add("&AElig", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 198 },
                Characters = "\u00C6"
            });
            Entities.Add("&AElig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 198 },
                Characters = "\u00C6"
            });
            Entities.Add("&AMP", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 38 },
                Characters = "\u0026"
            });
            Entities.Add("&AMP;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 38 },
                Characters = "\u0026"
            });
            Entities.Add("&Aacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 193 },
                Characters = "\u00C1"
            });
            Entities.Add("&Aacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 193 },
                Characters = "\u00C1"
            });
            Entities.Add("&Abreve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 258 },
                Characters = "\u0102"
            });
            Entities.Add("&Acirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 194 },
                Characters = "\u00C2"
            });
            Entities.Add("&Acirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 194 },
                Characters = "\u00C2"
            });
            Entities.Add("&Acy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1040 },
                Characters = "\u0410"
            });
            Entities.Add("&Afr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120068 },
                Characters = "\uD835\uDD04"
            });
            Entities.Add("&Agrave", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 192 },
                Characters = "\u00C0"
            });
            Entities.Add("&Agrave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 192 },
                Characters = "\u00C0"
            });
            Entities.Add("&Alpha;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 913 },
                Characters = "\u0391"
            });
            Entities.Add("&Amacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 256 },
                Characters = "\u0100"
            });
            Entities.Add("&And;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10835 },
                Characters = "\u2A53"
            });
            Entities.Add("&Aogon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 260 },
                Characters = "\u0104"
            });
            Entities.Add("&Aopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120120 },
                Characters = "\uD835\uDD38"
            });
            Entities.Add("&ApplyFunction;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8289 },
                Characters = "\u2061"
            });
            Entities.Add("&Aring", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 197 },
                Characters = "\u00C5"
            });
            Entities.Add("&Aring;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 197 },
                Characters = "\u00C5"
            });
            Entities.Add("&Ascr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119964 },
                Characters = "\uD835\uDC9C"
            });
            Entities.Add("&Assign;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8788 },
                Characters = "\u2254"
            });
            Entities.Add("&Atilde", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 195 },
                Characters = "\u00C3"
            });
            Entities.Add("&Atilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 195 },
                Characters = "\u00C3"
            });
            Entities.Add("&Auml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 196 },
                Characters = "\u00C4"
            });
            Entities.Add("&Auml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 196 },
                Characters = "\u00C4"
            });
            Entities.Add("&Backslash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8726 },
                Characters = "\u2216"
            });
            Entities.Add("&Barv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10983 },
                Characters = "\u2AE7"
            });
            Entities.Add("&Barwed;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8966 },
                Characters = "\u2306"
            });
            Entities.Add("&Bcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1041 },
                Characters = "\u0411"
            });
            Entities.Add("&Because;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8757 },
                Characters = "\u2235"
            });
            Entities.Add("&Bernoullis;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8492 },
                Characters = "\u212C"
            });
            Entities.Add("&Beta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 914 },
                Characters = "\u0392"
            });
            Entities.Add("&Bfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120069 },
                Characters = "\uD835\uDD05"
            });
            Entities.Add("&Bopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120121 },
                Characters = "\uD835\uDD39"
            });
            Entities.Add("&Breve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 728 },
                Characters = "\u02D8"
            });
            Entities.Add("&Bscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8492 },
                Characters = "\u212C"
            });
            Entities.Add("&Bumpeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8782 },
                Characters = "\u224E"
            });
            Entities.Add("&CHcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1063 },
                Characters = "\u0427"
            });
            Entities.Add("&COPY", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 169 },
                Characters = "\u00A9"
            });
            Entities.Add("&COPY;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 169 },
                Characters = "\u00A9"
            });
            Entities.Add("&Cacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 262 },
                Characters = "\u0106"
            });
            Entities.Add("&Cap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8914 },
                Characters = "\u22D2"
            });
            Entities.Add("&CapitalDifferentialD;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8517 },
                Characters = "\u2145"
            });
            Entities.Add("&Cayleys;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8493 },
                Characters = "\u212D"
            });
            Entities.Add("&Ccaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 268 },
                Characters = "\u010C"
            });
            Entities.Add("&Ccedil", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 199 },
                Characters = "\u00C7"
            });
            Entities.Add("&Ccedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 199 },
                Characters = "\u00C7"
            });
            Entities.Add("&Ccirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 264 },
                Characters = "\u0108"
            });
            Entities.Add("&Cconint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8752 },
                Characters = "\u2230"
            });
            Entities.Add("&Cdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 266 },
                Characters = "\u010A"
            });
            Entities.Add("&Cedilla;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 184 },
                Characters = "\u00B8"
            });
            Entities.Add("&CenterDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 183 },
                Characters = "\u00B7"
            });
            Entities.Add("&Cfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8493 },
                Characters = "\u212D"
            });
            Entities.Add("&Chi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 935 },
                Characters = "\u03A7"
            });
            Entities.Add("&CircleDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8857 },
                Characters = "\u2299"
            });
            Entities.Add("&CircleMinus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8854 },
                Characters = "\u2296"
            });
            Entities.Add("&CirclePlus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8853 },
                Characters = "\u2295"
            });
            Entities.Add("&CircleTimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8855 },
                Characters = "\u2297"
            });
            Entities.Add("&ClockwiseContourIntegral;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8754 },
                Characters = "\u2232"
            });
            Entities.Add("&CloseCurlyDoubleQuote;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8221 },
                Characters = "\u201D"
            });
            Entities.Add("&CloseCurlyQuote;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8217 },
                Characters = "\u2019"
            });
            Entities.Add("&Colon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8759 },
                Characters = "\u2237"
            });
            Entities.Add("&Colone;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10868 },
                Characters = "\u2A74"
            });
            Entities.Add("&Congruent;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8801 },
                Characters = "\u2261"
            });
            Entities.Add("&Conint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8751 },
                Characters = "\u222F"
            });
            Entities.Add("&ContourIntegral;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8750 },
                Characters = "\u222E"
            });
            Entities.Add("&Copf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8450 },
                Characters = "\u2102"
            });
            Entities.Add("&Coproduct;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8720 },
                Characters = "\u2210"
            });
            Entities.Add("&CounterClockwiseContourIntegral;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8755 },
                Characters = "\u2233"
            });
            Entities.Add("&Cross;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10799 },
                Characters = "\u2A2F"
            });
            Entities.Add("&Cscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119966 },
                Characters = "\uD835\uDC9E"
            });
            Entities.Add("&Cup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8915 },
                Characters = "\u22D3"
            });
            Entities.Add("&CupCap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8781 },
                Characters = "\u224D"
            });
            Entities.Add("&DD;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8517 },
                Characters = "\u2145"
            });
            Entities.Add("&DDotrahd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10513 },
                Characters = "\u2911"
            });
            Entities.Add("&DJcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1026 },
                Characters = "\u0402"
            });
            Entities.Add("&DScy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1029 },
                Characters = "\u0405"
            });
            Entities.Add("&DZcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1039 },
                Characters = "\u040F"
            });
            Entities.Add("&Dagger;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8225 },
                Characters = "\u2021"
            });
            Entities.Add("&Darr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8609 },
                Characters = "\u21A1"
            });
            Entities.Add("&Dashv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10980 },
                Characters = "\u2AE4"
            });
            Entities.Add("&Dcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 270 },
                Characters = "\u010E"
            });
            Entities.Add("&Dcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1044 },
                Characters = "\u0414"
            });
            Entities.Add("&Del;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8711 },
                Characters = "\u2207"
            });
            Entities.Add("&Delta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 916 },
                Characters = "\u0394"
            });
            Entities.Add("&Dfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120071 },
                Characters = "\uD835\uDD07"
            });
            Entities.Add("&DiacriticalAcute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 180 },
                Characters = "\u00B4"
            });
            Entities.Add("&DiacriticalDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 729 },
                Characters = "\u02D9"
            });
            Entities.Add("&DiacriticalDoubleAcute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 733 },
                Characters = "\u02DD"
            });
            Entities.Add("&DiacriticalGrave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 96 },
                Characters = "\u0060"
            });
            Entities.Add("&DiacriticalTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 732 },
                Characters = "\u02DC"
            });
            Entities.Add("&Diamond;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8900 },
                Characters = "\u22C4"
            });
            Entities.Add("&DifferentialD;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8518 },
                Characters = "\u2146"
            });
            Entities.Add("&Dopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120123 },
                Characters = "\uD835\uDD3B"
            });
            Entities.Add("&Dot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 168 },
                Characters = "\u00A8"
            });
            Entities.Add("&DotDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8412 },
                Characters = "\u20DC"
            });
            Entities.Add("&DotEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8784 },
                Characters = "\u2250"
            });
            Entities.Add("&DoubleContourIntegral;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8751 },
                Characters = "\u222F"
            });
            Entities.Add("&DoubleDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 168 },
                Characters = "\u00A8"
            });
            Entities.Add("&DoubleDownArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8659 },
                Characters = "\u21D3"
            });
            Entities.Add("&DoubleLeftArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8656 },
                Characters = "\u21D0"
            });
            Entities.Add("&DoubleLeftRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8660 },
                Characters = "\u21D4"
            });
            Entities.Add("&DoubleLeftTee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10980 },
                Characters = "\u2AE4"
            });
            Entities.Add("&DoubleLongLeftArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10232 },
                Characters = "\u27F8"
            });
            Entities.Add("&DoubleLongLeftRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10234 },
                Characters = "\u27FA"
            });
            Entities.Add("&DoubleLongRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10233 },
                Characters = "\u27F9"
            });
            Entities.Add("&DoubleRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8658 },
                Characters = "\u21D2"
            });
            Entities.Add("&DoubleRightTee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8872 },
                Characters = "\u22A8"
            });
            Entities.Add("&DoubleUpArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8657 },
                Characters = "\u21D1"
            });
            Entities.Add("&DoubleUpDownArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8661 },
                Characters = "\u21D5"
            });
            Entities.Add("&DoubleVerticalBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8741 },
                Characters = "\u2225"
            });
            Entities.Add("&DownArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8595 },
                Characters = "\u2193"
            });
            Entities.Add("&DownArrowBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10515 },
                Characters = "\u2913"
            });
            Entities.Add("&DownArrowUpArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8693 },
                Characters = "\u21F5"
            });
            Entities.Add("&DownBreve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 785 },
                Characters = "\u0311"
            });
            Entities.Add("&DownLeftRightVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10576 },
                Characters = "\u2950"
            });
            Entities.Add("&DownLeftTeeVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10590 },
                Characters = "\u295E"
            });
            Entities.Add("&DownLeftVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8637 },
                Characters = "\u21BD"
            });
            Entities.Add("&DownLeftVectorBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10582 },
                Characters = "\u2956"
            });
            Entities.Add("&DownRightTeeVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10591 },
                Characters = "\u295F"
            });
            Entities.Add("&DownRightVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8641 },
                Characters = "\u21C1"
            });
            Entities.Add("&DownRightVectorBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10583 },
                Characters = "\u2957"
            });
            Entities.Add("&DownTee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8868 },
                Characters = "\u22A4"
            });
            Entities.Add("&DownTeeArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8615 },
                Characters = "\u21A7"
            });
            Entities.Add("&Downarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8659 },
                Characters = "\u21D3"
            });
            Entities.Add("&Dscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119967 },
                Characters = "\uD835\uDC9F"
            });
            Entities.Add("&Dstrok;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 272 },
                Characters = "\u0110"
            });
            Entities.Add("&ENG;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 330 },
                Characters = "\u014A"
            });
            Entities.Add("&ETH", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 208 },
                Characters = "\u00D0"
            });
            Entities.Add("&ETH;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 208 },
                Characters = "\u00D0"
            });
            Entities.Add("&Eacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 201 },
                Characters = "\u00C9"
            });
            Entities.Add("&Eacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 201 },
                Characters = "\u00C9"
            });
            Entities.Add("&Ecaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 282 },
                Characters = "\u011A"
            });
            Entities.Add("&Ecirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 202 },
                Characters = "\u00CA"
            });
            Entities.Add("&Ecirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 202 },
                Characters = "\u00CA"
            });
            Entities.Add("&Ecy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1069 },
                Characters = "\u042D"
            });
            Entities.Add("&Edot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 278 },
                Characters = "\u0116"
            });
            Entities.Add("&Efr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120072 },
                Characters = "\uD835\uDD08"
            });
            Entities.Add("&Egrave", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 200 },
                Characters = "\u00C8"
            });
            Entities.Add("&Egrave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 200 },
                Characters = "\u00C8"
            });
            Entities.Add("&Element;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8712 },
                Characters = "\u2208"
            });
            Entities.Add("&Emacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 274 },
                Characters = "\u0112"
            });
            Entities.Add("&EmptySmallSquare;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9723 },
                Characters = "\u25FB"
            });
            Entities.Add("&EmptyVerySmallSquare;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9643 },
                Characters = "\u25AB"
            });
            Entities.Add("&Eogon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 280 },
                Characters = "\u0118"
            });
            Entities.Add("&Eopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120124 },
                Characters = "\uD835\uDD3C"
            });
            Entities.Add("&Epsilon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 917 },
                Characters = "\u0395"
            });
            Entities.Add("&Equal;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10869 },
                Characters = "\u2A75"
            });
            Entities.Add("&EqualTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8770 },
                Characters = "\u2242"
            });
            Entities.Add("&Equilibrium;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8652 },
                Characters = "\u21CC"
            });
            Entities.Add("&Escr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8496 },
                Characters = "\u2130"
            });
            Entities.Add("&Esim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10867 },
                Characters = "\u2A73"
            });
            Entities.Add("&Eta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 919 },
                Characters = "\u0397"
            });
            Entities.Add("&Euml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 203 },
                Characters = "\u00CB"
            });
            Entities.Add("&Euml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 203 },
                Characters = "\u00CB"
            });
            Entities.Add("&Exists;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8707 },
                Characters = "\u2203"
            });
            Entities.Add("&ExponentialE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8519 },
                Characters = "\u2147"
            });
            Entities.Add("&Fcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1060 },
                Characters = "\u0424"
            });
            Entities.Add("&Ffr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120073 },
                Characters = "\uD835\uDD09"
            });
            Entities.Add("&FilledSmallSquare;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9724 },
                Characters = "\u25FC"
            });
            Entities.Add("&FilledVerySmallSquare;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9642 },
                Characters = "\u25AA"
            });
            Entities.Add("&Fopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120125 },
                Characters = "\uD835\uDD3D"
            });
            Entities.Add("&ForAll;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8704 },
                Characters = "\u2200"
            });
            Entities.Add("&Fouriertrf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8497 },
                Characters = "\u2131"
            });
            Entities.Add("&Fscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8497 },
                Characters = "\u2131"
            });
            Entities.Add("&GJcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1027 },
                Characters = "\u0403"
            });
            Entities.Add("&GT", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 62 },
                Characters = "\u003E"
            });
            Entities.Add("&GT;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 62 },
                Characters = "\u003E"
            });
            Entities.Add("&Gamma;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 915 },
                Characters = "\u0393"
            });
            Entities.Add("&Gammad;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 988 },
                Characters = "\u03DC"
            });
            Entities.Add("&Gbreve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 286 },
                Characters = "\u011E"
            });
            Entities.Add("&Gcedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 290 },
                Characters = "\u0122"
            });
            Entities.Add("&Gcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 284 },
                Characters = "\u011C"
            });
            Entities.Add("&Gcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1043 },
                Characters = "\u0413"
            });
            Entities.Add("&Gdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 288 },
                Characters = "\u0120"
            });
            Entities.Add("&Gfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120074 },
                Characters = "\uD835\uDD0A"
            });
            Entities.Add("&Gg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8921 },
                Characters = "\u22D9"
            });
            Entities.Add("&Gopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120126 },
                Characters = "\uD835\uDD3E"
            });
            Entities.Add("&GreaterEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8805 },
                Characters = "\u2265"
            });
            Entities.Add("&GreaterEqualLess;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8923 },
                Characters = "\u22DB"
            });
            Entities.Add("&GreaterFullEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8807 },
                Characters = "\u2267"
            });
            Entities.Add("&GreaterGreater;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10914 },
                Characters = "\u2AA2"
            });
            Entities.Add("&GreaterLess;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8823 },
                Characters = "\u2277"
            });
            Entities.Add("&GreaterSlantEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10878 },
                Characters = "\u2A7E"
            });
            Entities.Add("&GreaterTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8819 },
                Characters = "\u2273"
            });
            Entities.Add("&Gscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119970 },
                Characters = "\uD835\uDCA2"
            });
            Entities.Add("&Gt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8811 },
                Characters = "\u226B"
            });
            Entities.Add("&HARDcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1066 },
                Characters = "\u042A"
            });
            Entities.Add("&Hacek;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 711 },
                Characters = "\u02C7"
            });
            Entities.Add("&Hat;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 94 },
                Characters = "\u005E"
            });
            Entities.Add("&Hcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 292 },
                Characters = "\u0124"
            });
            Entities.Add("&Hfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8460 },
                Characters = "\u210C"
            });
            Entities.Add("&HilbertSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8459 },
                Characters = "\u210B"
            });
            Entities.Add("&Hopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8461 },
                Characters = "\u210D"
            });
            Entities.Add("&HorizontalLine;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9472 },
                Characters = "\u2500"
            });
            Entities.Add("&Hscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8459 },
                Characters = "\u210B"
            });
            Entities.Add("&Hstrok;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 294 },
                Characters = "\u0126"
            });
            Entities.Add("&HumpDownHump;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8782 },
                Characters = "\u224E"
            });
            Entities.Add("&HumpEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8783 },
                Characters = "\u224F"
            });
            Entities.Add("&IEcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1045 },
                Characters = "\u0415"
            });
            Entities.Add("&IJlig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 306 },
                Characters = "\u0132"
            });
            Entities.Add("&IOcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1025 },
                Characters = "\u0401"
            });
            Entities.Add("&Iacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 205 },
                Characters = "\u00CD"
            });
            Entities.Add("&Iacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 205 },
                Characters = "\u00CD"
            });
            Entities.Add("&Icirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 206 },
                Characters = "\u00CE"
            });
            Entities.Add("&Icirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 206 },
                Characters = "\u00CE"
            });
            Entities.Add("&Icy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1048 },
                Characters = "\u0418"
            });
            Entities.Add("&Idot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 304 },
                Characters = "\u0130"
            });
            Entities.Add("&Ifr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8465 },
                Characters = "\u2111"
            });
            Entities.Add("&Igrave", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 204 },
                Characters = "\u00CC"
            });
            Entities.Add("&Igrave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 204 },
                Characters = "\u00CC"
            });
            Entities.Add("&Im;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8465 },
                Characters = "\u2111"
            });
            Entities.Add("&Imacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 298 },
                Characters = "\u012A"
            });
            Entities.Add("&ImaginaryI;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8520 },
                Characters = "\u2148"
            });
            Entities.Add("&Implies;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8658 },
                Characters = "\u21D2"
            });
            Entities.Add("&Int;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8748 },
                Characters = "\u222C"
            });
            Entities.Add("&Integral;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8747 },
                Characters = "\u222B"
            });
            Entities.Add("&Intersection;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8898 },
                Characters = "\u22C2"
            });
            Entities.Add("&InvisibleComma;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8291 },
                Characters = "\u2063"
            });
            Entities.Add("&InvisibleTimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8290 },
                Characters = "\u2062"
            });
            Entities.Add("&Iogon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 302 },
                Characters = "\u012E"
            });
            Entities.Add("&Iopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120128 },
                Characters = "\uD835\uDD40"
            });
            Entities.Add("&Iota;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 921 },
                Characters = "\u0399"
            });
            Entities.Add("&Iscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8464 },
                Characters = "\u2110"
            });
            Entities.Add("&Itilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 296 },
                Characters = "\u0128"
            });
            Entities.Add("&Iukcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1030 },
                Characters = "\u0406"
            });
            Entities.Add("&Iuml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 207 },
                Characters = "\u00CF"
            });
            Entities.Add("&Iuml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 207 },
                Characters = "\u00CF"
            });
            Entities.Add("&Jcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 308 },
                Characters = "\u0134"
            });
            Entities.Add("&Jcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1049 },
                Characters = "\u0419"
            });
            Entities.Add("&Jfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120077 },
                Characters = "\uD835\uDD0D"
            });
            Entities.Add("&Jopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120129 },
                Characters = "\uD835\uDD41"
            });
            Entities.Add("&Jscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119973 },
                Characters = "\uD835\uDCA5"
            });
            Entities.Add("&Jsercy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1032 },
                Characters = "\u0408"
            });
            Entities.Add("&Jukcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1028 },
                Characters = "\u0404"
            });
            Entities.Add("&KHcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1061 },
                Characters = "\u0425"
            });
            Entities.Add("&KJcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1036 },
                Characters = "\u040C"
            });
            Entities.Add("&Kappa;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 922 },
                Characters = "\u039A"
            });
            Entities.Add("&Kcedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 310 },
                Characters = "\u0136"
            });
            Entities.Add("&Kcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1050 },
                Characters = "\u041A"
            });
            Entities.Add("&Kfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120078 },
                Characters = "\uD835\uDD0E"
            });
            Entities.Add("&Kopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120130 },
                Characters = "\uD835\uDD42"
            });
            Entities.Add("&Kscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119974 },
                Characters = "\uD835\uDCA6"
            });
            Entities.Add("&LJcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1033 },
                Characters = "\u0409"
            });
            Entities.Add("&LT", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 60 },
                Characters = "\u003C"
            });
            Entities.Add("&LT;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 60 },
                Characters = "\u003C"
            });
            Entities.Add("&Lacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 313 },
                Characters = "\u0139"
            });
            Entities.Add("&Lambda;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 923 },
                Characters = "\u039B"
            });
            Entities.Add("&Lang;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10218 },
                Characters = "\u27EA"
            });
            Entities.Add("&Laplacetrf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8466 },
                Characters = "\u2112"
            });
            Entities.Add("&Larr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8606 },
                Characters = "\u219E"
            });
            Entities.Add("&Lcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 317 },
                Characters = "\u013D"
            });
            Entities.Add("&Lcedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 315 },
                Characters = "\u013B"
            });
            Entities.Add("&Lcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1051 },
                Characters = "\u041B"
            });
            Entities.Add("&LeftAngleBracket;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10216 },
                Characters = "\u27E8"
            });
            Entities.Add("&LeftArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8592 },
                Characters = "\u2190"
            });
            Entities.Add("&LeftArrowBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8676 },
                Characters = "\u21E4"
            });
            Entities.Add("&LeftArrowRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8646 },
                Characters = "\u21C6"
            });
            Entities.Add("&LeftCeiling;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8968 },
                Characters = "\u2308"
            });
            Entities.Add("&LeftDoubleBracket;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10214 },
                Characters = "\u27E6"
            });
            Entities.Add("&LeftDownTeeVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10593 },
                Characters = "\u2961"
            });
            Entities.Add("&LeftDownVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8643 },
                Characters = "\u21C3"
            });
            Entities.Add("&LeftDownVectorBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10585 },
                Characters = "\u2959"
            });
            Entities.Add("&LeftFloor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8970 },
                Characters = "\u230A"
            });
            Entities.Add("&LeftRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8596 },
                Characters = "\u2194"
            });
            Entities.Add("&LeftRightVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10574 },
                Characters = "\u294E"
            });
            Entities.Add("&LeftTee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8867 },
                Characters = "\u22A3"
            });
            Entities.Add("&LeftTeeArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8612 },
                Characters = "\u21A4"
            });
            Entities.Add("&LeftTeeVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10586 },
                Characters = "\u295A"
            });
            Entities.Add("&LeftTriangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8882 },
                Characters = "\u22B2"
            });
            Entities.Add("&LeftTriangleBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10703 },
                Characters = "\u29CF"
            });
            Entities.Add("&LeftTriangleEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8884 },
                Characters = "\u22B4"
            });
            Entities.Add("&LeftUpDownVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10577 },
                Characters = "\u2951"
            });
            Entities.Add("&LeftUpTeeVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10592 },
                Characters = "\u2960"
            });
            Entities.Add("&LeftUpVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8639 },
                Characters = "\u21BF"
            });
            Entities.Add("&LeftUpVectorBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10584 },
                Characters = "\u2958"
            });
            Entities.Add("&LeftVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8636 },
                Characters = "\u21BC"
            });
            Entities.Add("&LeftVectorBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10578 },
                Characters = "\u2952"
            });
            Entities.Add("&Leftarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8656 },
                Characters = "\u21D0"
            });
            Entities.Add("&Leftrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8660 },
                Characters = "\u21D4"
            });
            Entities.Add("&LessEqualGreater;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8922 },
                Characters = "\u22DA"
            });
            Entities.Add("&LessFullEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8806 },
                Characters = "\u2266"
            });
            Entities.Add("&LessGreater;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8822 },
                Characters = "\u2276"
            });
            Entities.Add("&LessLess;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10913 },
                Characters = "\u2AA1"
            });
            Entities.Add("&LessSlantEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10877 },
                Characters = "\u2A7D"
            });
            Entities.Add("&LessTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8818 },
                Characters = "\u2272"
            });
            Entities.Add("&Lfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120079 },
                Characters = "\uD835\uDD0F"
            });
            Entities.Add("&Ll;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8920 },
                Characters = "\u22D8"
            });
            Entities.Add("&Lleftarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8666 },
                Characters = "\u21DA"
            });
            Entities.Add("&Lmidot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 319 },
                Characters = "\u013F"
            });
            Entities.Add("&LongLeftArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10229 },
                Characters = "\u27F5"
            });
            Entities.Add("&LongLeftRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10231 },
                Characters = "\u27F7"
            });
            Entities.Add("&LongRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10230 },
                Characters = "\u27F6"
            });
            Entities.Add("&Longleftarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10232 },
                Characters = "\u27F8"
            });
            Entities.Add("&Longleftrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10234 },
                Characters = "\u27FA"
            });
            Entities.Add("&Longrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10233 },
                Characters = "\u27F9"
            });
            Entities.Add("&Lopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120131 },
                Characters = "\uD835\uDD43"
            });
            Entities.Add("&LowerLeftArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8601 },
                Characters = "\u2199"
            });
            Entities.Add("&LowerRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8600 },
                Characters = "\u2198"
            });
            Entities.Add("&Lscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8466 },
                Characters = "\u2112"
            });
            Entities.Add("&Lsh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8624 },
                Characters = "\u21B0"
            });
            Entities.Add("&Lstrok;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 321 },
                Characters = "\u0141"
            });
            Entities.Add("&Lt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8810 },
                Characters = "\u226A"
            });
            Entities.Add("&Map;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10501 },
                Characters = "\u2905"
            });
            Entities.Add("&Mcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1052 },
                Characters = "\u041C"
            });
            Entities.Add("&MediumSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8287 },
                Characters = "\u205F"
            });
            Entities.Add("&Mellintrf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8499 },
                Characters = "\u2133"
            });
            Entities.Add("&Mfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120080 },
                Characters = "\uD835\uDD10"
            });
            Entities.Add("&MinusPlus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8723 },
                Characters = "\u2213"
            });
            Entities.Add("&Mopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120132 },
                Characters = "\uD835\uDD44"
            });
            Entities.Add("&Mscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8499 },
                Characters = "\u2133"
            });
            Entities.Add("&Mu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 924 },
                Characters = "\u039C"
            });
            Entities.Add("&NJcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1034 },
                Characters = "\u040A"
            });
            Entities.Add("&Nacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 323 },
                Characters = "\u0143"
            });
            Entities.Add("&Ncaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 327 },
                Characters = "\u0147"
            });
            Entities.Add("&Ncedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 325 },
                Characters = "\u0145"
            });
            Entities.Add("&Ncy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1053 },
                Characters = "\u041D"
            });
            Entities.Add("&NegativeMediumSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8203 },
                Characters = "\u200B"
            });
            Entities.Add("&NegativeThickSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8203 },
                Characters = "\u200B"
            });
            Entities.Add("&NegativeThinSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8203 },
                Characters = "\u200B"
            });
            Entities.Add("&NegativeVeryThinSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8203 },
                Characters = "\u200B"
            });
            Entities.Add("&NestedGreaterGreater;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8811 },
                Characters = "\u226B"
            });
            Entities.Add("&NestedLessLess;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8810 },
                Characters = "\u226A"
            });
            Entities.Add("&NewLine;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10 },
                Characters = "\u000A"
            });
            Entities.Add("&Nfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120081 },
                Characters = "\uD835\uDD11"
            });
            Entities.Add("&NoBreak;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8288 },
                Characters = "\u2060"
            });
            Entities.Add("&NonBreakingSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 160 },
                Characters = "\u00A0"
            });
            Entities.Add("&Nopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8469 },
                Characters = "\u2115"
            });
            Entities.Add("&Not;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10988 },
                Characters = "\u2AEC"
            });
            Entities.Add("&NotCongruent;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8802 },
                Characters = "\u2262"
            });
            Entities.Add("&NotCupCap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8813 },
                Characters = "\u226D"
            });
            Entities.Add("&NotDoubleVerticalBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8742 },
                Characters = "\u2226"
            });
            Entities.Add("&NotElement;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8713 },
                Characters = "\u2209"
            });
            Entities.Add("&NotEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8800 },
                Characters = "\u2260"
            });
            Entities.Add("&NotEqualTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8770, 824 },
                Characters = "\u2242\u0338"
            });
            Entities.Add("&NotExists;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8708 },
                Characters = "\u2204"
            });
            Entities.Add("&NotGreater;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8815 },
                Characters = "\u226F"
            });
            Entities.Add("&NotGreaterEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8817 },
                Characters = "\u2271"
            });
            Entities.Add("&NotGreaterFullEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8807, 824 },
                Characters = "\u2267\u0338"
            });
            Entities.Add("&NotGreaterGreater;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8811, 824 },
                Characters = "\u226B\u0338"
            });
            Entities.Add("&NotGreaterLess;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8825 },
                Characters = "\u2279"
            });
            Entities.Add("&NotGreaterSlantEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10878, 824 },
                Characters = "\u2A7E\u0338"
            });
            Entities.Add("&NotGreaterTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8821 },
                Characters = "\u2275"
            });
            Entities.Add("&NotHumpDownHump;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8782, 824 },
                Characters = "\u224E\u0338"
            });
            Entities.Add("&NotHumpEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8783, 824 },
                Characters = "\u224F\u0338"
            });
            Entities.Add("&NotLeftTriangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8938 },
                Characters = "\u22EA"
            });
            Entities.Add("&NotLeftTriangleBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10703, 824 },
                Characters = "\u29CF\u0338"
            });
            Entities.Add("&NotLeftTriangleEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8940 },
                Characters = "\u22EC"
            });
            Entities.Add("&NotLess;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8814 },
                Characters = "\u226E"
            });
            Entities.Add("&NotLessEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8816 },
                Characters = "\u2270"
            });
            Entities.Add("&NotLessGreater;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8824 },
                Characters = "\u2278"
            });
            Entities.Add("&NotLessLess;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8810, 824 },
                Characters = "\u226A\u0338"
            });
            Entities.Add("&NotLessSlantEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10877, 824 },
                Characters = "\u2A7D\u0338"
            });
            Entities.Add("&NotLessTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8820 },
                Characters = "\u2274"
            });
            Entities.Add("&NotNestedGreaterGreater;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10914, 824 },
                Characters = "\u2AA2\u0338"
            });
            Entities.Add("&NotNestedLessLess;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10913, 824 },
                Characters = "\u2AA1\u0338"
            });
            Entities.Add("&NotPrecedes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8832 },
                Characters = "\u2280"
            });
            Entities.Add("&NotPrecedesEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10927, 824 },
                Characters = "\u2AAF\u0338"
            });
            Entities.Add("&NotPrecedesSlantEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8928 },
                Characters = "\u22E0"
            });
            Entities.Add("&NotReverseElement;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8716 },
                Characters = "\u220C"
            });
            Entities.Add("&NotRightTriangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8939 },
                Characters = "\u22EB"
            });
            Entities.Add("&NotRightTriangleBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10704, 824 },
                Characters = "\u29D0\u0338"
            });
            Entities.Add("&NotRightTriangleEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8941 },
                Characters = "\u22ED"
            });
            Entities.Add("&NotSquareSubset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8847, 824 },
                Characters = "\u228F\u0338"
            });
            Entities.Add("&NotSquareSubsetEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8930 },
                Characters = "\u22E2"
            });
            Entities.Add("&NotSquareSuperset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8848, 824 },
                Characters = "\u2290\u0338"
            });
            Entities.Add("&NotSquareSupersetEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8931 },
                Characters = "\u22E3"
            });
            Entities.Add("&NotSubset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8834, 8402 },
                Characters = "\u2282\u20D2"
            });
            Entities.Add("&NotSubsetEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8840 },
                Characters = "\u2288"
            });
            Entities.Add("&NotSucceeds;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8833 },
                Characters = "\u2281"
            });
            Entities.Add("&NotSucceedsEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10928, 824 },
                Characters = "\u2AB0\u0338"
            });
            Entities.Add("&NotSucceedsSlantEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8929 },
                Characters = "\u22E1"
            });
            Entities.Add("&NotSucceedsTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8831, 824 },
                Characters = "\u227F\u0338"
            });
            Entities.Add("&NotSuperset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8835, 8402 },
                Characters = "\u2283\u20D2"
            });
            Entities.Add("&NotSupersetEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8841 },
                Characters = "\u2289"
            });
            Entities.Add("&NotTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8769 },
                Characters = "\u2241"
            });
            Entities.Add("&NotTildeEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8772 },
                Characters = "\u2244"
            });
            Entities.Add("&NotTildeFullEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8775 },
                Characters = "\u2247"
            });
            Entities.Add("&NotTildeTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8777 },
                Characters = "\u2249"
            });
            Entities.Add("&NotVerticalBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8740 },
                Characters = "\u2224"
            });
            Entities.Add("&Nscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119977 },
                Characters = "\uD835\uDCA9"
            });
            Entities.Add("&Ntilde", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 209 },
                Characters = "\u00D1"
            });
            Entities.Add("&Ntilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 209 },
                Characters = "\u00D1"
            });
            Entities.Add("&Nu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 925 },
                Characters = "\u039D"
            });
            Entities.Add("&OElig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 338 },
                Characters = "\u0152"
            });
            Entities.Add("&Oacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 211 },
                Characters = "\u00D3"
            });
            Entities.Add("&Oacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 211 },
                Characters = "\u00D3"
            });
            Entities.Add("&Ocirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 212 },
                Characters = "\u00D4"
            });
            Entities.Add("&Ocirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 212 },
                Characters = "\u00D4"
            });
            Entities.Add("&Ocy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1054 },
                Characters = "\u041E"
            });
            Entities.Add("&Odblac;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 336 },
                Characters = "\u0150"
            });
            Entities.Add("&Ofr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120082 },
                Characters = "\uD835\uDD12"
            });
            Entities.Add("&Ograve", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 210 },
                Characters = "\u00D2"
            });
            Entities.Add("&Ograve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 210 },
                Characters = "\u00D2"
            });
            Entities.Add("&Omacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 332 },
                Characters = "\u014C"
            });
            Entities.Add("&Omega;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 937 },
                Characters = "\u03A9"
            });
            Entities.Add("&Omicron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 927 },
                Characters = "\u039F"
            });
            Entities.Add("&Oopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120134 },
                Characters = "\uD835\uDD46"
            });
            Entities.Add("&OpenCurlyDoubleQuote;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8220 },
                Characters = "\u201C"
            });
            Entities.Add("&OpenCurlyQuote;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8216 },
                Characters = "\u2018"
            });
            Entities.Add("&Or;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10836 },
                Characters = "\u2A54"
            });
            Entities.Add("&Oscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119978 },
                Characters = "\uD835\uDCAA"
            });
            Entities.Add("&Oslash", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 216 },
                Characters = "\u00D8"
            });
            Entities.Add("&Oslash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 216 },
                Characters = "\u00D8"
            });
            Entities.Add("&Otilde", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 213 },
                Characters = "\u00D5"
            });
            Entities.Add("&Otilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 213 },
                Characters = "\u00D5"
            });
            Entities.Add("&Otimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10807 },
                Characters = "\u2A37"
            });
            Entities.Add("&Ouml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 214 },
                Characters = "\u00D6"
            });
            Entities.Add("&Ouml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 214 },
                Characters = "\u00D6"
            });
            Entities.Add("&OverBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8254 },
                Characters = "\u203E"
            });
            Entities.Add("&OverBrace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9182 },
                Characters = "\u23DE"
            });
            Entities.Add("&OverBracket;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9140 },
                Characters = "\u23B4"
            });
            Entities.Add("&OverParenthesis;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9180 },
                Characters = "\u23DC"
            });
            Entities.Add("&PartialD;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8706 },
                Characters = "\u2202"
            });
            Entities.Add("&Pcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1055 },
                Characters = "\u041F"
            });
            Entities.Add("&Pfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120083 },
                Characters = "\uD835\uDD13"
            });
            Entities.Add("&Phi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 934 },
                Characters = "\u03A6"
            });
            Entities.Add("&Pi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 928 },
                Characters = "\u03A0"
            });
            Entities.Add("&PlusMinus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 177 },
                Characters = "\u00B1"
            });
            Entities.Add("&Poincareplane;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8460 },
                Characters = "\u210C"
            });
            Entities.Add("&Popf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8473 },
                Characters = "\u2119"
            });
            Entities.Add("&Pr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10939 },
                Characters = "\u2ABB"
            });
            Entities.Add("&Precedes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8826 },
                Characters = "\u227A"
            });
            Entities.Add("&PrecedesEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10927 },
                Characters = "\u2AAF"
            });
            Entities.Add("&PrecedesSlantEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8828 },
                Characters = "\u227C"
            });
            Entities.Add("&PrecedesTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8830 },
                Characters = "\u227E"
            });
            Entities.Add("&Prime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8243 },
                Characters = "\u2033"
            });
            Entities.Add("&Product;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8719 },
                Characters = "\u220F"
            });
            Entities.Add("&Proportion;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8759 },
                Characters = "\u2237"
            });
            Entities.Add("&Proportional;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8733 },
                Characters = "\u221D"
            });
            Entities.Add("&Pscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119979 },
                Characters = "\uD835\uDCAB"
            });
            Entities.Add("&Psi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 936 },
                Characters = "\u03A8"
            });
            Entities.Add("&QUOT", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 34 },
                Characters = "\u0022"
            });
            Entities.Add("&QUOT;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 34 },
                Characters = "\u0022"
            });
            Entities.Add("&Qfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120084 },
                Characters = "\uD835\uDD14"
            });
            Entities.Add("&Qopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8474 },
                Characters = "\u211A"
            });
            Entities.Add("&Qscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119980 },
                Characters = "\uD835\uDCAC"
            });
            Entities.Add("&RBarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10512 },
                Characters = "\u2910"
            });
            Entities.Add("&REG", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 174 },
                Characters = "\u00AE"
            });
            Entities.Add("&REG;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 174 },
                Characters = "\u00AE"
            });
            Entities.Add("&Racute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 340 },
                Characters = "\u0154"
            });
            Entities.Add("&Rang;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10219 },
                Characters = "\u27EB"
            });
            Entities.Add("&Rarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8608 },
                Characters = "\u21A0"
            });
            Entities.Add("&Rarrtl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10518 },
                Characters = "\u2916"
            });
            Entities.Add("&Rcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 344 },
                Characters = "\u0158"
            });
            Entities.Add("&Rcedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 342 },
                Characters = "\u0156"
            });
            Entities.Add("&Rcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1056 },
                Characters = "\u0420"
            });
            Entities.Add("&Re;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8476 },
                Characters = "\u211C"
            });
            Entities.Add("&ReverseElement;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8715 },
                Characters = "\u220B"
            });
            Entities.Add("&ReverseEquilibrium;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8651 },
                Characters = "\u21CB"
            });
            Entities.Add("&ReverseUpEquilibrium;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10607 },
                Characters = "\u296F"
            });
            Entities.Add("&Rfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8476 },
                Characters = "\u211C"
            });
            Entities.Add("&Rho;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 929 },
                Characters = "\u03A1"
            });
            Entities.Add("&RightAngleBracket;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10217 },
                Characters = "\u27E9"
            });
            Entities.Add("&RightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8594 },
                Characters = "\u2192"
            });
            Entities.Add("&RightArrowBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8677 },
                Characters = "\u21E5"
            });
            Entities.Add("&RightArrowLeftArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8644 },
                Characters = "\u21C4"
            });
            Entities.Add("&RightCeiling;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8969 },
                Characters = "\u2309"
            });
            Entities.Add("&RightDoubleBracket;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10215 },
                Characters = "\u27E7"
            });
            Entities.Add("&RightDownTeeVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10589 },
                Characters = "\u295D"
            });
            Entities.Add("&RightDownVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8642 },
                Characters = "\u21C2"
            });
            Entities.Add("&RightDownVectorBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10581 },
                Characters = "\u2955"
            });
            Entities.Add("&RightFloor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8971 },
                Characters = "\u230B"
            });
            Entities.Add("&RightTee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8866 },
                Characters = "\u22A2"
            });
            Entities.Add("&RightTeeArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8614 },
                Characters = "\u21A6"
            });
            Entities.Add("&RightTeeVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10587 },
                Characters = "\u295B"
            });
            Entities.Add("&RightTriangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8883 },
                Characters = "\u22B3"
            });
            Entities.Add("&RightTriangleBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10704 },
                Characters = "\u29D0"
            });
            Entities.Add("&RightTriangleEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8885 },
                Characters = "\u22B5"
            });
            Entities.Add("&RightUpDownVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10575 },
                Characters = "\u294F"
            });
            Entities.Add("&RightUpTeeVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10588 },
                Characters = "\u295C"
            });
            Entities.Add("&RightUpVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8638 },
                Characters = "\u21BE"
            });
            Entities.Add("&RightUpVectorBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10580 },
                Characters = "\u2954"
            });
            Entities.Add("&RightVector;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8640 },
                Characters = "\u21C0"
            });
            Entities.Add("&RightVectorBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10579 },
                Characters = "\u2953"
            });
            Entities.Add("&Rightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8658 },
                Characters = "\u21D2"
            });
            Entities.Add("&Ropf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8477 },
                Characters = "\u211D"
            });
            Entities.Add("&RoundImplies;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10608 },
                Characters = "\u2970"
            });
            Entities.Add("&Rrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8667 },
                Characters = "\u21DB"
            });
            Entities.Add("&Rscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8475 },
                Characters = "\u211B"
            });
            Entities.Add("&Rsh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8625 },
                Characters = "\u21B1"
            });
            Entities.Add("&RuleDelayed;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10740 },
                Characters = "\u29F4"
            });
            Entities.Add("&SHCHcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1065 },
                Characters = "\u0429"
            });
            Entities.Add("&SHcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1064 },
                Characters = "\u0428"
            });
            Entities.Add("&SOFTcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1068 },
                Characters = "\u042C"
            });
            Entities.Add("&Sacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 346 },
                Characters = "\u015A"
            });
            Entities.Add("&Sc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10940 },
                Characters = "\u2ABC"
            });
            Entities.Add("&Scaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 352 },
                Characters = "\u0160"
            });
            Entities.Add("&Scedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 350 },
                Characters = "\u015E"
            });
            Entities.Add("&Scirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 348 },
                Characters = "\u015C"
            });
            Entities.Add("&Scy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1057 },
                Characters = "\u0421"
            });
            Entities.Add("&Sfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120086 },
                Characters = "\uD835\uDD16"
            });
            Entities.Add("&ShortDownArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8595 },
                Characters = "\u2193"
            });
            Entities.Add("&ShortLeftArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8592 },
                Characters = "\u2190"
            });
            Entities.Add("&ShortRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8594 },
                Characters = "\u2192"
            });
            Entities.Add("&ShortUpArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8593 },
                Characters = "\u2191"
            });
            Entities.Add("&Sigma;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 931 },
                Characters = "\u03A3"
            });
            Entities.Add("&SmallCircle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8728 },
                Characters = "\u2218"
            });
            Entities.Add("&Sopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120138 },
                Characters = "\uD835\uDD4A"
            });
            Entities.Add("&Sqrt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8730 },
                Characters = "\u221A"
            });
            Entities.Add("&Square;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9633 },
                Characters = "\u25A1"
            });
            Entities.Add("&SquareIntersection;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8851 },
                Characters = "\u2293"
            });
            Entities.Add("&SquareSubset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8847 },
                Characters = "\u228F"
            });
            Entities.Add("&SquareSubsetEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8849 },
                Characters = "\u2291"
            });
            Entities.Add("&SquareSuperset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8848 },
                Characters = "\u2290"
            });
            Entities.Add("&SquareSupersetEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8850 },
                Characters = "\u2292"
            });
            Entities.Add("&SquareUnion;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8852 },
                Characters = "\u2294"
            });
            Entities.Add("&Sscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119982 },
                Characters = "\uD835\uDCAE"
            });
            Entities.Add("&Star;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8902 },
                Characters = "\u22C6"
            });
            Entities.Add("&Sub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8912 },
                Characters = "\u22D0"
            });
            Entities.Add("&Subset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8912 },
                Characters = "\u22D0"
            });
            Entities.Add("&SubsetEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8838 },
                Characters = "\u2286"
            });
            Entities.Add("&Succeeds;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8827 },
                Characters = "\u227B"
            });
            Entities.Add("&SucceedsEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10928 },
                Characters = "\u2AB0"
            });
            Entities.Add("&SucceedsSlantEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8829 },
                Characters = "\u227D"
            });
            Entities.Add("&SucceedsTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8831 },
                Characters = "\u227F"
            });
            Entities.Add("&SuchThat;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8715 },
                Characters = "\u220B"
            });
            Entities.Add("&Sum;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8721 },
                Characters = "\u2211"
            });
            Entities.Add("&Sup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8913 },
                Characters = "\u22D1"
            });
            Entities.Add("&Superset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8835 },
                Characters = "\u2283"
            });
            Entities.Add("&SupersetEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8839 },
                Characters = "\u2287"
            });
            Entities.Add("&Supset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8913 },
                Characters = "\u22D1"
            });
            Entities.Add("&THORN", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 222 },
                Characters = "\u00DE"
            });
            Entities.Add("&THORN;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 222 },
                Characters = "\u00DE"
            });
            Entities.Add("&TRADE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8482 },
                Characters = "\u2122"
            });
            Entities.Add("&TSHcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1035 },
                Characters = "\u040B"
            });
            Entities.Add("&TScy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1062 },
                Characters = "\u0426"
            });
            Entities.Add("&Tab;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9 },
                Characters = "\u0009"
            });
            Entities.Add("&Tau;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 932 },
                Characters = "\u03A4"
            });
            Entities.Add("&Tcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 356 },
                Characters = "\u0164"
            });
            Entities.Add("&Tcedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 354 },
                Characters = "\u0162"
            });
            Entities.Add("&Tcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1058 },
                Characters = "\u0422"
            });
            Entities.Add("&Tfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120087 },
                Characters = "\uD835\uDD17"
            });
            Entities.Add("&Therefore;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8756 },
                Characters = "\u2234"
            });
            Entities.Add("&Theta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 920 },
                Characters = "\u0398"
            });
            Entities.Add("&ThickSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8287, 8202 },
                Characters = "\u205F\u200A"
            });
            Entities.Add("&ThinSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8201 },
                Characters = "\u2009"
            });
            Entities.Add("&Tilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8764 },
                Characters = "\u223C"
            });
            Entities.Add("&TildeEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8771 },
                Characters = "\u2243"
            });
            Entities.Add("&TildeFullEqual;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8773 },
                Characters = "\u2245"
            });
            Entities.Add("&TildeTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8776 },
                Characters = "\u2248"
            });
            Entities.Add("&Topf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120139 },
                Characters = "\uD835\uDD4B"
            });
            Entities.Add("&TripleDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8411 },
                Characters = "\u20DB"
            });
            Entities.Add("&Tscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119983 },
                Characters = "\uD835\uDCAF"
            });
            Entities.Add("&Tstrok;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 358 },
                Characters = "\u0166"
            });
            Entities.Add("&Uacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 218 },
                Characters = "\u00DA"
            });
            Entities.Add("&Uacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 218 },
                Characters = "\u00DA"
            });
            Entities.Add("&Uarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8607 },
                Characters = "\u219F"
            });
            Entities.Add("&Uarrocir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10569 },
                Characters = "\u2949"
            });
            Entities.Add("&Ubrcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1038 },
                Characters = "\u040E"
            });
            Entities.Add("&Ubreve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 364 },
                Characters = "\u016C"
            });
            Entities.Add("&Ucirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 219 },
                Characters = "\u00DB"
            });
            Entities.Add("&Ucirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 219 },
                Characters = "\u00DB"
            });
            Entities.Add("&Ucy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1059 },
                Characters = "\u0423"
            });
            Entities.Add("&Udblac;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 368 },
                Characters = "\u0170"
            });
            Entities.Add("&Ufr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120088 },
                Characters = "\uD835\uDD18"
            });
            Entities.Add("&Ugrave", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 217 },
                Characters = "\u00D9"
            });
            Entities.Add("&Ugrave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 217 },
                Characters = "\u00D9"
            });
            Entities.Add("&Umacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 362 },
                Characters = "\u016A"
            });
            Entities.Add("&UnderBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 95 },
                Characters = "\u005F"
            });
            Entities.Add("&UnderBrace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9183 },
                Characters = "\u23DF"
            });
            Entities.Add("&UnderBracket;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9141 },
                Characters = "\u23B5"
            });
            Entities.Add("&UnderParenthesis;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9181 },
                Characters = "\u23DD"
            });
            Entities.Add("&Union;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8899 },
                Characters = "\u22C3"
            });
            Entities.Add("&UnionPlus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8846 },
                Characters = "\u228E"
            });
            Entities.Add("&Uogon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 370 },
                Characters = "\u0172"
            });
            Entities.Add("&Uopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120140 },
                Characters = "\uD835\uDD4C"
            });
            Entities.Add("&UpArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8593 },
                Characters = "\u2191"
            });
            Entities.Add("&UpArrowBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10514 },
                Characters = "\u2912"
            });
            Entities.Add("&UpArrowDownArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8645 },
                Characters = "\u21C5"
            });
            Entities.Add("&UpDownArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8597 },
                Characters = "\u2195"
            });
            Entities.Add("&UpEquilibrium;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10606 },
                Characters = "\u296E"
            });
            Entities.Add("&UpTee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8869 },
                Characters = "\u22A5"
            });
            Entities.Add("&UpTeeArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8613 },
                Characters = "\u21A5"
            });
            Entities.Add("&Uparrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8657 },
                Characters = "\u21D1"
            });
            Entities.Add("&Updownarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8661 },
                Characters = "\u21D5"
            });
            Entities.Add("&UpperLeftArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8598 },
                Characters = "\u2196"
            });
            Entities.Add("&UpperRightArrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8599 },
                Characters = "\u2197"
            });
            Entities.Add("&Upsi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 978 },
                Characters = "\u03D2"
            });
            Entities.Add("&Upsilon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 933 },
                Characters = "\u03A5"
            });
            Entities.Add("&Uring;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 366 },
                Characters = "\u016E"
            });
            Entities.Add("&Uscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119984 },
                Characters = "\uD835\uDCB0"
            });
            Entities.Add("&Utilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 360 },
                Characters = "\u0168"
            });
            Entities.Add("&Uuml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 220 },
                Characters = "\u00DC"
            });
            Entities.Add("&Uuml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 220 },
                Characters = "\u00DC"
            });
            Entities.Add("&VDash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8875 },
                Characters = "\u22AB"
            });
            Entities.Add("&Vbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10987 },
                Characters = "\u2AEB"
            });
            Entities.Add("&Vcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1042 },
                Characters = "\u0412"
            });
            Entities.Add("&Vdash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8873 },
                Characters = "\u22A9"
            });
            Entities.Add("&Vdashl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10982 },
                Characters = "\u2AE6"
            });
            Entities.Add("&Vee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8897 },
                Characters = "\u22C1"
            });
            Entities.Add("&Verbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8214 },
                Characters = "\u2016"
            });
            Entities.Add("&Vert;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8214 },
                Characters = "\u2016"
            });
            Entities.Add("&VerticalBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8739 },
                Characters = "\u2223"
            });
            Entities.Add("&VerticalLine;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 124 },
                Characters = "\u007C"
            });
            Entities.Add("&VerticalSeparator;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10072 },
                Characters = "\u2758"
            });
            Entities.Add("&VerticalTilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8768 },
                Characters = "\u2240"
            });
            Entities.Add("&VeryThinSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8202 },
                Characters = "\u200A"
            });
            Entities.Add("&Vfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120089 },
                Characters = "\uD835\uDD19"
            });
            Entities.Add("&Vopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120141 },
                Characters = "\uD835\uDD4D"
            });
            Entities.Add("&Vscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119985 },
                Characters = "\uD835\uDCB1"
            });
            Entities.Add("&Vvdash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8874 },
                Characters = "\u22AA"
            });
            Entities.Add("&Wcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 372 },
                Characters = "\u0174"
            });
            Entities.Add("&Wedge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8896 },
                Characters = "\u22C0"
            });
            Entities.Add("&Wfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120090 },
                Characters = "\uD835\uDD1A"
            });
            Entities.Add("&Wopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120142 },
                Characters = "\uD835\uDD4E"
            });
            Entities.Add("&Wscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119986 },
                Characters = "\uD835\uDCB2"
            });
            Entities.Add("&Xfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120091 },
                Characters = "\uD835\uDD1B"
            });
            Entities.Add("&Xi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 926 },
                Characters = "\u039E"
            });
            Entities.Add("&Xopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120143 },
                Characters = "\uD835\uDD4F"
            });
            Entities.Add("&Xscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119987 },
                Characters = "\uD835\uDCB3"
            });
            Entities.Add("&YAcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1071 },
                Characters = "\u042F"
            });
            Entities.Add("&YIcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1031 },
                Characters = "\u0407"
            });
            Entities.Add("&YUcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1070 },
                Characters = "\u042E"
            });
            Entities.Add("&Yacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 221 },
                Characters = "\u00DD"
            });
            Entities.Add("&Yacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 221 },
                Characters = "\u00DD"
            });
            Entities.Add("&Ycirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 374 },
                Characters = "\u0176"
            });
            Entities.Add("&Ycy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1067 },
                Characters = "\u042B"
            });
            Entities.Add("&Yfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120092 },
                Characters = "\uD835\uDD1C"
            });
            Entities.Add("&Yopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120144 },
                Characters = "\uD835\uDD50"
            });
            Entities.Add("&Yscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119988 },
                Characters = "\uD835\uDCB4"
            });
            Entities.Add("&Yuml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 376 },
                Characters = "\u0178"
            });
            Entities.Add("&ZHcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1046 },
                Characters = "\u0416"
            });
            Entities.Add("&Zacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 377 },
                Characters = "\u0179"
            });
            Entities.Add("&Zcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 381 },
                Characters = "\u017D"
            });
            Entities.Add("&Zcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1047 },
                Characters = "\u0417"
            });
            Entities.Add("&Zdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 379 },
                Characters = "\u017B"
            });
            Entities.Add("&ZeroWidthSpace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8203 },
                Characters = "\u200B"
            });
            Entities.Add("&Zeta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 918 },
                Characters = "\u0396"
            });
            Entities.Add("&Zfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8488 },
                Characters = "\u2128"
            });
            Entities.Add("&Zopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8484 },
                Characters = "\u2124"
            });
            Entities.Add("&Zscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119989 },
                Characters = "\uD835\uDCB5"
            });
            Entities.Add("&aacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 225 },
                Characters = "\u00E1"
            });
            Entities.Add("&aacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 225 },
                Characters = "\u00E1"
            });
            Entities.Add("&abreve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 259 },
                Characters = "\u0103"
            });
            Entities.Add("&ac;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8766 },
                Characters = "\u223E"
            });
            Entities.Add("&acE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8766, 819 },
                Characters = "\u223E\u0333"
            });
            Entities.Add("&acd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8767 },
                Characters = "\u223F"
            });
            Entities.Add("&acirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 226 },
                Characters = "\u00E2"
            });
            Entities.Add("&acirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 226 },
                Characters = "\u00E2"
            });
            Entities.Add("&acute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 180 },
                Characters = "\u00B4"
            });
            Entities.Add("&acute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 180 },
                Characters = "\u00B4"
            });
            Entities.Add("&acy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1072 },
                Characters = "\u0430"
            });
            Entities.Add("&aelig", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 230 },
                Characters = "\u00E6"
            });
            Entities.Add("&aelig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 230 },
                Characters = "\u00E6"
            });
            Entities.Add("&af;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8289 },
                Characters = "\u2061"
            });
            Entities.Add("&afr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120094 },
                Characters = "\uD835\uDD1E"
            });
            Entities.Add("&agrave", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 224 },
                Characters = "\u00E0"
            });
            Entities.Add("&agrave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 224 },
                Characters = "\u00E0"
            });
            Entities.Add("&alefsym;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8501 },
                Characters = "\u2135"
            });
            Entities.Add("&aleph;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8501 },
                Characters = "\u2135"
            });
            Entities.Add("&alpha;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 945 },
                Characters = "\u03B1"
            });
            Entities.Add("&amacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 257 },
                Characters = "\u0101"
            });
            Entities.Add("&amalg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10815 },
                Characters = "\u2A3F"
            });
            Entities.Add("&amp", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 38 },
                Characters = "\u0026"
            });
            Entities.Add("&amp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 38 },
                Characters = "\u0026"
            });
            Entities.Add("&and;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8743 },
                Characters = "\u2227"
            });
            Entities.Add("&andand;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10837 },
                Characters = "\u2A55"
            });
            Entities.Add("&andd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10844 },
                Characters = "\u2A5C"
            });
            Entities.Add("&andslope;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10840 },
                Characters = "\u2A58"
            });
            Entities.Add("&andv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10842 },
                Characters = "\u2A5A"
            });
            Entities.Add("&ang;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8736 },
                Characters = "\u2220"
            });
            Entities.Add("&ange;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10660 },
                Characters = "\u29A4"
            });
            Entities.Add("&angle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8736 },
                Characters = "\u2220"
            });
            Entities.Add("&angmsd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8737 },
                Characters = "\u2221"
            });
            Entities.Add("&angmsdaa;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10664 },
                Characters = "\u29A8"
            });
            Entities.Add("&angmsdab;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10665 },
                Characters = "\u29A9"
            });
            Entities.Add("&angmsdac;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10666 },
                Characters = "\u29AA"
            });
            Entities.Add("&angmsdad;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10667 },
                Characters = "\u29AB"
            });
            Entities.Add("&angmsdae;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10668 },
                Characters = "\u29AC"
            });
            Entities.Add("&angmsdaf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10669 },
                Characters = "\u29AD"
            });
            Entities.Add("&angmsdag;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10670 },
                Characters = "\u29AE"
            });
            Entities.Add("&angmsdah;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10671 },
                Characters = "\u29AF"
            });
            Entities.Add("&angrt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8735 },
                Characters = "\u221F"
            });
            Entities.Add("&angrtvb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8894 },
                Characters = "\u22BE"
            });
            Entities.Add("&angrtvbd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10653 },
                Characters = "\u299D"
            });
            Entities.Add("&angsph;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8738 },
                Characters = "\u2222"
            });
            Entities.Add("&angst;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 197 },
                Characters = "\u00C5"
            });
            Entities.Add("&angzarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9084 },
                Characters = "\u237C"
            });
            Entities.Add("&aogon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 261 },
                Characters = "\u0105"
            });
            Entities.Add("&aopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120146 },
                Characters = "\uD835\uDD52"
            });
            Entities.Add("&ap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8776 },
                Characters = "\u2248"
            });
            Entities.Add("&apE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10864 },
                Characters = "\u2A70"
            });
            Entities.Add("&apacir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10863 },
                Characters = "\u2A6F"
            });
            Entities.Add("&ape;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8778 },
                Characters = "\u224A"
            });
            Entities.Add("&apid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8779 },
                Characters = "\u224B"
            });
            Entities.Add("&apos;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 39 },
                Characters = "\u0027"
            });
            Entities.Add("&approx;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8776 },
                Characters = "\u2248"
            });
            Entities.Add("&approxeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8778 },
                Characters = "\u224A"
            });
            Entities.Add("&aring", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 229 },
                Characters = "\u00E5"
            });
            Entities.Add("&aring;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 229 },
                Characters = "\u00E5"
            });
            Entities.Add("&ascr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119990 },
                Characters = "\uD835\uDCB6"
            });
            Entities.Add("&ast;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 42 },
                Characters = "\u002A"
            });
            Entities.Add("&asymp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8776 },
                Characters = "\u2248"
            });
            Entities.Add("&asympeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8781 },
                Characters = "\u224D"
            });
            Entities.Add("&atilde", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 227 },
                Characters = "\u00E3"
            });
            Entities.Add("&atilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 227 },
                Characters = "\u00E3"
            });
            Entities.Add("&auml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 228 },
                Characters = "\u00E4"
            });
            Entities.Add("&auml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 228 },
                Characters = "\u00E4"
            });
            Entities.Add("&awconint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8755 },
                Characters = "\u2233"
            });
            Entities.Add("&awint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10769 },
                Characters = "\u2A11"
            });
            Entities.Add("&bNot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10989 },
                Characters = "\u2AED"
            });
            Entities.Add("&backcong;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8780 },
                Characters = "\u224C"
            });
            Entities.Add("&backepsilon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1014 },
                Characters = "\u03F6"
            });
            Entities.Add("&backprime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8245 },
                Characters = "\u2035"
            });
            Entities.Add("&backsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8765 },
                Characters = "\u223D"
            });
            Entities.Add("&backsimeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8909 },
                Characters = "\u22CD"
            });
            Entities.Add("&barvee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8893 },
                Characters = "\u22BD"
            });
            Entities.Add("&barwed;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8965 },
                Characters = "\u2305"
            });
            Entities.Add("&barwedge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8965 },
                Characters = "\u2305"
            });
            Entities.Add("&bbrk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9141 },
                Characters = "\u23B5"
            });
            Entities.Add("&bbrktbrk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9142 },
                Characters = "\u23B6"
            });
            Entities.Add("&bcong;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8780 },
                Characters = "\u224C"
            });
            Entities.Add("&bcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1073 },
                Characters = "\u0431"
            });
            Entities.Add("&bdquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8222 },
                Characters = "\u201E"
            });
            Entities.Add("&becaus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8757 },
                Characters = "\u2235"
            });
            Entities.Add("&because;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8757 },
                Characters = "\u2235"
            });
            Entities.Add("&bemptyv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10672 },
                Characters = "\u29B0"
            });
            Entities.Add("&bepsi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1014 },
                Characters = "\u03F6"
            });
            Entities.Add("&bernou;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8492 },
                Characters = "\u212C"
            });
            Entities.Add("&beta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 946 },
                Characters = "\u03B2"
            });
            Entities.Add("&beth;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8502 },
                Characters = "\u2136"
            });
            Entities.Add("&between;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8812 },
                Characters = "\u226C"
            });
            Entities.Add("&bfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120095 },
                Characters = "\uD835\uDD1F"
            });
            Entities.Add("&bigcap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8898 },
                Characters = "\u22C2"
            });
            Entities.Add("&bigcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9711 },
                Characters = "\u25EF"
            });
            Entities.Add("&bigcup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8899 },
                Characters = "\u22C3"
            });
            Entities.Add("&bigodot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10752 },
                Characters = "\u2A00"
            });
            Entities.Add("&bigoplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10753 },
                Characters = "\u2A01"
            });
            Entities.Add("&bigotimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10754 },
                Characters = "\u2A02"
            });
            Entities.Add("&bigsqcup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10758 },
                Characters = "\u2A06"
            });
            Entities.Add("&bigstar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9733 },
                Characters = "\u2605"
            });
            Entities.Add("&bigtriangledown;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9661 },
                Characters = "\u25BD"
            });
            Entities.Add("&bigtriangleup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9651 },
                Characters = "\u25B3"
            });
            Entities.Add("&biguplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10756 },
                Characters = "\u2A04"
            });
            Entities.Add("&bigvee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8897 },
                Characters = "\u22C1"
            });
            Entities.Add("&bigwedge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8896 },
                Characters = "\u22C0"
            });
            Entities.Add("&bkarow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10509 },
                Characters = "\u290D"
            });
            Entities.Add("&blacklozenge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10731 },
                Characters = "\u29EB"
            });
            Entities.Add("&blacksquare;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9642 },
                Characters = "\u25AA"
            });
            Entities.Add("&blacktriangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9652 },
                Characters = "\u25B4"
            });
            Entities.Add("&blacktriangledown;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9662 },
                Characters = "\u25BE"
            });
            Entities.Add("&blacktriangleleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9666 },
                Characters = "\u25C2"
            });
            Entities.Add("&blacktriangleright;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9656 },
                Characters = "\u25B8"
            });
            Entities.Add("&blank;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9251 },
                Characters = "\u2423"
            });
            Entities.Add("&blk12;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9618 },
                Characters = "\u2592"
            });
            Entities.Add("&blk14;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9617 },
                Characters = "\u2591"
            });
            Entities.Add("&blk34;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9619 },
                Characters = "\u2593"
            });
            Entities.Add("&block;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9608 },
                Characters = "\u2588"
            });
            Entities.Add("&bne;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 61, 8421 },
                Characters = "\u003D\u20E5"
            });
            Entities.Add("&bnequiv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8801, 8421 },
                Characters = "\u2261\u20E5"
            });
            Entities.Add("&bnot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8976 },
                Characters = "\u2310"
            });
            Entities.Add("&bopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120147 },
                Characters = "\uD835\uDD53"
            });
            Entities.Add("&bot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8869 },
                Characters = "\u22A5"
            });
            Entities.Add("&bottom;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8869 },
                Characters = "\u22A5"
            });
            Entities.Add("&bowtie;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8904 },
                Characters = "\u22C8"
            });
            Entities.Add("&boxDL;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9559 },
                Characters = "\u2557"
            });
            Entities.Add("&boxDR;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9556 },
                Characters = "\u2554"
            });
            Entities.Add("&boxDl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9558 },
                Characters = "\u2556"
            });
            Entities.Add("&boxDr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9555 },
                Characters = "\u2553"
            });
            Entities.Add("&boxH;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9552 },
                Characters = "\u2550"
            });
            Entities.Add("&boxHD;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9574 },
                Characters = "\u2566"
            });
            Entities.Add("&boxHU;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9577 },
                Characters = "\u2569"
            });
            Entities.Add("&boxHd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9572 },
                Characters = "\u2564"
            });
            Entities.Add("&boxHu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9575 },
                Characters = "\u2567"
            });
            Entities.Add("&boxUL;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9565 },
                Characters = "\u255D"
            });
            Entities.Add("&boxUR;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9562 },
                Characters = "\u255A"
            });
            Entities.Add("&boxUl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9564 },
                Characters = "\u255C"
            });
            Entities.Add("&boxUr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9561 },
                Characters = "\u2559"
            });
            Entities.Add("&boxV;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9553 },
                Characters = "\u2551"
            });
            Entities.Add("&boxVH;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9580 },
                Characters = "\u256C"
            });
            Entities.Add("&boxVL;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9571 },
                Characters = "\u2563"
            });
            Entities.Add("&boxVR;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9568 },
                Characters = "\u2560"
            });
            Entities.Add("&boxVh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9579 },
                Characters = "\u256B"
            });
            Entities.Add("&boxVl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9570 },
                Characters = "\u2562"
            });
            Entities.Add("&boxVr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9567 },
                Characters = "\u255F"
            });
            Entities.Add("&boxbox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10697 },
                Characters = "\u29C9"
            });
            Entities.Add("&boxdL;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9557 },
                Characters = "\u2555"
            });
            Entities.Add("&boxdR;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9554 },
                Characters = "\u2552"
            });
            Entities.Add("&boxdl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9488 },
                Characters = "\u2510"
            });
            Entities.Add("&boxdr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9484 },
                Characters = "\u250C"
            });
            Entities.Add("&boxh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9472 },
                Characters = "\u2500"
            });
            Entities.Add("&boxhD;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9573 },
                Characters = "\u2565"
            });
            Entities.Add("&boxhU;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9576 },
                Characters = "\u2568"
            });
            Entities.Add("&boxhd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9516 },
                Characters = "\u252C"
            });
            Entities.Add("&boxhu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9524 },
                Characters = "\u2534"
            });
            Entities.Add("&boxminus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8863 },
                Characters = "\u229F"
            });
            Entities.Add("&boxplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8862 },
                Characters = "\u229E"
            });
            Entities.Add("&boxtimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8864 },
                Characters = "\u22A0"
            });
            Entities.Add("&boxuL;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9563 },
                Characters = "\u255B"
            });
            Entities.Add("&boxuR;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9560 },
                Characters = "\u2558"
            });
            Entities.Add("&boxul;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9496 },
                Characters = "\u2518"
            });
            Entities.Add("&boxur;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9492 },
                Characters = "\u2514"
            });
            Entities.Add("&boxv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9474 },
                Characters = "\u2502"
            });
            Entities.Add("&boxvH;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9578 },
                Characters = "\u256A"
            });
            Entities.Add("&boxvL;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9569 },
                Characters = "\u2561"
            });
            Entities.Add("&boxvR;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9566 },
                Characters = "\u255E"
            });
            Entities.Add("&boxvh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9532 },
                Characters = "\u253C"
            });
            Entities.Add("&boxvl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9508 },
                Characters = "\u2524"
            });
            Entities.Add("&boxvr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9500 },
                Characters = "\u251C"
            });
            Entities.Add("&bprime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8245 },
                Characters = "\u2035"
            });
            Entities.Add("&breve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 728 },
                Characters = "\u02D8"
            });
            Entities.Add("&brvbar", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 166 },
                Characters = "\u00A6"
            });
            Entities.Add("&brvbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 166 },
                Characters = "\u00A6"
            });
            Entities.Add("&bscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119991 },
                Characters = "\uD835\uDCB7"
            });
            Entities.Add("&bsemi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8271 },
                Characters = "\u204F"
            });
            Entities.Add("&bsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8765 },
                Characters = "\u223D"
            });
            Entities.Add("&bsime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8909 },
                Characters = "\u22CD"
            });
            Entities.Add("&bsol;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 92 },
                Characters = "\u005C"
            });
            Entities.Add("&bsolb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10693 },
                Characters = "\u29C5"
            });
            Entities.Add("&bsolhsub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10184 },
                Characters = "\u27C8"
            });
            Entities.Add("&bull;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8226 },
                Characters = "\u2022"
            });
            Entities.Add("&bullet;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8226 },
                Characters = "\u2022"
            });
            Entities.Add("&bump;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8782 },
                Characters = "\u224E"
            });
            Entities.Add("&bumpE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10926 },
                Characters = "\u2AAE"
            });
            Entities.Add("&bumpe;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8783 },
                Characters = "\u224F"
            });
            Entities.Add("&bumpeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8783 },
                Characters = "\u224F"
            });
            Entities.Add("&cacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 263 },
                Characters = "\u0107"
            });
            Entities.Add("&cap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8745 },
                Characters = "\u2229"
            });
            Entities.Add("&capand;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10820 },
                Characters = "\u2A44"
            });
            Entities.Add("&capbrcup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10825 },
                Characters = "\u2A49"
            });
            Entities.Add("&capcap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10827 },
                Characters = "\u2A4B"
            });
            Entities.Add("&capcup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10823 },
                Characters = "\u2A47"
            });
            Entities.Add("&capdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10816 },
                Characters = "\u2A40"
            });
            Entities.Add("&caps;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8745, 65024 },
                Characters = "\u2229\uFE00"
            });
            Entities.Add("&caret;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8257 },
                Characters = "\u2041"
            });
            Entities.Add("&caron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 711 },
                Characters = "\u02C7"
            });
            Entities.Add("&ccaps;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10829 },
                Characters = "\u2A4D"
            });
            Entities.Add("&ccaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 269 },
                Characters = "\u010D"
            });
            Entities.Add("&ccedil", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 231 },
                Characters = "\u00E7"
            });
            Entities.Add("&ccedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 231 },
                Characters = "\u00E7"
            });
            Entities.Add("&ccirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 265 },
                Characters = "\u0109"
            });
            Entities.Add("&ccups;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10828 },
                Characters = "\u2A4C"
            });
            Entities.Add("&ccupssm;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10832 },
                Characters = "\u2A50"
            });
            Entities.Add("&cdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 267 },
                Characters = "\u010B"
            });
            Entities.Add("&cedil", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 184 },
                Characters = "\u00B8"
            });
            Entities.Add("&cedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 184 },
                Characters = "\u00B8"
            });
            Entities.Add("&cemptyv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10674 },
                Characters = "\u29B2"
            });
            Entities.Add("&cent", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 162 },
                Characters = "\u00A2"
            });
            Entities.Add("&cent;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 162 },
                Characters = "\u00A2"
            });
            Entities.Add("&centerdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 183 },
                Characters = "\u00B7"
            });
            Entities.Add("&cfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120096 },
                Characters = "\uD835\uDD20"
            });
            Entities.Add("&chcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1095 },
                Characters = "\u0447"
            });
            Entities.Add("&check;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10003 },
                Characters = "\u2713"
            });
            Entities.Add("&checkmark;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10003 },
                Characters = "\u2713"
            });
            Entities.Add("&chi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 967 },
                Characters = "\u03C7"
            });
            Entities.Add("&cir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9675 },
                Characters = "\u25CB"
            });
            Entities.Add("&cirE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10691 },
                Characters = "\u29C3"
            });
            Entities.Add("&circ;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 710 },
                Characters = "\u02C6"
            });
            Entities.Add("&circeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8791 },
                Characters = "\u2257"
            });
            Entities.Add("&circlearrowleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8634 },
                Characters = "\u21BA"
            });
            Entities.Add("&circlearrowright;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8635 },
                Characters = "\u21BB"
            });
            Entities.Add("&circledR;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 174 },
                Characters = "\u00AE"
            });
            Entities.Add("&circledS;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9416 },
                Characters = "\u24C8"
            });
            Entities.Add("&circledast;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8859 },
                Characters = "\u229B"
            });
            Entities.Add("&circledcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8858 },
                Characters = "\u229A"
            });
            Entities.Add("&circleddash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8861 },
                Characters = "\u229D"
            });
            Entities.Add("&cire;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8791 },
                Characters = "\u2257"
            });
            Entities.Add("&cirfnint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10768 },
                Characters = "\u2A10"
            });
            Entities.Add("&cirmid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10991 },
                Characters = "\u2AEF"
            });
            Entities.Add("&cirscir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10690 },
                Characters = "\u29C2"
            });
            Entities.Add("&clubs;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9827 },
                Characters = "\u2663"
            });
            Entities.Add("&clubsuit;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9827 },
                Characters = "\u2663"
            });
            Entities.Add("&colon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 58 },
                Characters = "\u003A"
            });
            Entities.Add("&colone;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8788 },
                Characters = "\u2254"
            });
            Entities.Add("&coloneq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8788 },
                Characters = "\u2254"
            });
            Entities.Add("&comma;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 44 },
                Characters = "\u002C"
            });
            Entities.Add("&commat;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 64 },
                Characters = "\u0040"
            });
            Entities.Add("&comp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8705 },
                Characters = "\u2201"
            });
            Entities.Add("&compfn;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8728 },
                Characters = "\u2218"
            });
            Entities.Add("&complement;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8705 },
                Characters = "\u2201"
            });
            Entities.Add("&complexes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8450 },
                Characters = "\u2102"
            });
            Entities.Add("&cong;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8773 },
                Characters = "\u2245"
            });
            Entities.Add("&congdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10861 },
                Characters = "\u2A6D"
            });
            Entities.Add("&conint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8750 },
                Characters = "\u222E"
            });
            Entities.Add("&copf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120148 },
                Characters = "\uD835\uDD54"
            });
            Entities.Add("&coprod;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8720 },
                Characters = "\u2210"
            });
            Entities.Add("&copy", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 169 },
                Characters = "\u00A9"
            });
            Entities.Add("&copy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 169 },
                Characters = "\u00A9"
            });
            Entities.Add("&copysr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8471 },
                Characters = "\u2117"
            });
            Entities.Add("&crarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8629 },
                Characters = "\u21B5"
            });
            Entities.Add("&cross;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10007 },
                Characters = "\u2717"
            });
            Entities.Add("&cscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119992 },
                Characters = "\uD835\uDCB8"
            });
            Entities.Add("&csub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10959 },
                Characters = "\u2ACF"
            });
            Entities.Add("&csube;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10961 },
                Characters = "\u2AD1"
            });
            Entities.Add("&csup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10960 },
                Characters = "\u2AD0"
            });
            Entities.Add("&csupe;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10962 },
                Characters = "\u2AD2"
            });
            Entities.Add("&ctdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8943 },
                Characters = "\u22EF"
            });
            Entities.Add("&cudarrl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10552 },
                Characters = "\u2938"
            });
            Entities.Add("&cudarrr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10549 },
                Characters = "\u2935"
            });
            Entities.Add("&cuepr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8926 },
                Characters = "\u22DE"
            });
            Entities.Add("&cuesc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8927 },
                Characters = "\u22DF"
            });
            Entities.Add("&cularr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8630 },
                Characters = "\u21B6"
            });
            Entities.Add("&cularrp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10557 },
                Characters = "\u293D"
            });
            Entities.Add("&cup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8746 },
                Characters = "\u222A"
            });
            Entities.Add("&cupbrcap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10824 },
                Characters = "\u2A48"
            });
            Entities.Add("&cupcap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10822 },
                Characters = "\u2A46"
            });
            Entities.Add("&cupcup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10826 },
                Characters = "\u2A4A"
            });
            Entities.Add("&cupdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8845 },
                Characters = "\u228D"
            });
            Entities.Add("&cupor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10821 },
                Characters = "\u2A45"
            });
            Entities.Add("&cups;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8746, 65024 },
                Characters = "\u222A\uFE00"
            });
            Entities.Add("&curarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8631 },
                Characters = "\u21B7"
            });
            Entities.Add("&curarrm;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10556 },
                Characters = "\u293C"
            });
            Entities.Add("&curlyeqprec;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8926 },
                Characters = "\u22DE"
            });
            Entities.Add("&curlyeqsucc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8927 },
                Characters = "\u22DF"
            });
            Entities.Add("&curlyvee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8910 },
                Characters = "\u22CE"
            });
            Entities.Add("&curlywedge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8911 },
                Characters = "\u22CF"
            });
            Entities.Add("&curren", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 164 },
                Characters = "\u00A4"
            });
            Entities.Add("&curren;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 164 },
                Characters = "\u00A4"
            });
            Entities.Add("&curvearrowleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8630 },
                Characters = "\u21B6"
            });
            Entities.Add("&curvearrowright;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8631 },
                Characters = "\u21B7"
            });
            Entities.Add("&cuvee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8910 },
                Characters = "\u22CE"
            });
            Entities.Add("&cuwed;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8911 },
                Characters = "\u22CF"
            });
            Entities.Add("&cwconint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8754 },
                Characters = "\u2232"
            });
            Entities.Add("&cwint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8753 },
                Characters = "\u2231"
            });
            Entities.Add("&cylcty;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9005 },
                Characters = "\u232D"
            });
            Entities.Add("&dArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8659 },
                Characters = "\u21D3"
            });
            Entities.Add("&dHar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10597 },
                Characters = "\u2965"
            });
            Entities.Add("&dagger;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8224 },
                Characters = "\u2020"
            });
            Entities.Add("&daleth;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8504 },
                Characters = "\u2138"
            });
            Entities.Add("&darr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8595 },
                Characters = "\u2193"
            });
            Entities.Add("&dash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8208 },
                Characters = "\u2010"
            });
            Entities.Add("&dashv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8867 },
                Characters = "\u22A3"
            });
            Entities.Add("&dbkarow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10511 },
                Characters = "\u290F"
            });
            Entities.Add("&dblac;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 733 },
                Characters = "\u02DD"
            });
            Entities.Add("&dcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 271 },
                Characters = "\u010F"
            });
            Entities.Add("&dcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1076 },
                Characters = "\u0434"
            });
            Entities.Add("&dd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8518 },
                Characters = "\u2146"
            });
            Entities.Add("&ddagger;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8225 },
                Characters = "\u2021"
            });
            Entities.Add("&ddarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8650 },
                Characters = "\u21CA"
            });
            Entities.Add("&ddotseq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10871 },
                Characters = "\u2A77"
            });
            Entities.Add("&deg", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 176 },
                Characters = "\u00B0"
            });
            Entities.Add("&deg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 176 },
                Characters = "\u00B0"
            });
            Entities.Add("&delta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 948 },
                Characters = "\u03B4"
            });
            Entities.Add("&demptyv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10673 },
                Characters = "\u29B1"
            });
            Entities.Add("&dfisht;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10623 },
                Characters = "\u297F"
            });
            Entities.Add("&dfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120097 },
                Characters = "\uD835\uDD21"
            });
            Entities.Add("&dharl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8643 },
                Characters = "\u21C3"
            });
            Entities.Add("&dharr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8642 },
                Characters = "\u21C2"
            });
            Entities.Add("&diam;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8900 },
                Characters = "\u22C4"
            });
            Entities.Add("&diamond;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8900 },
                Characters = "\u22C4"
            });
            Entities.Add("&diamondsuit;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9830 },
                Characters = "\u2666"
            });
            Entities.Add("&diams;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9830 },
                Characters = "\u2666"
            });
            Entities.Add("&die;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 168 },
                Characters = "\u00A8"
            });
            Entities.Add("&digamma;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 989 },
                Characters = "\u03DD"
            });
            Entities.Add("&disin;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8946 },
                Characters = "\u22F2"
            });
            Entities.Add("&div;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 247 },
                Characters = "\u00F7"
            });
            Entities.Add("&divide", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 247 },
                Characters = "\u00F7"
            });
            Entities.Add("&divide;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 247 },
                Characters = "\u00F7"
            });
            Entities.Add("&divideontimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8903 },
                Characters = "\u22C7"
            });
            Entities.Add("&divonx;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8903 },
                Characters = "\u22C7"
            });
            Entities.Add("&djcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1106 },
                Characters = "\u0452"
            });
            Entities.Add("&dlcorn;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8990 },
                Characters = "\u231E"
            });
            Entities.Add("&dlcrop;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8973 },
                Characters = "\u230D"
            });
            Entities.Add("&dollar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 36 },
                Characters = "\u0024"
            });
            Entities.Add("&dopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120149 },
                Characters = "\uD835\uDD55"
            });
            Entities.Add("&dot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 729 },
                Characters = "\u02D9"
            });
            Entities.Add("&doteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8784 },
                Characters = "\u2250"
            });
            Entities.Add("&doteqdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8785 },
                Characters = "\u2251"
            });
            Entities.Add("&dotminus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8760 },
                Characters = "\u2238"
            });
            Entities.Add("&dotplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8724 },
                Characters = "\u2214"
            });
            Entities.Add("&dotsquare;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8865 },
                Characters = "\u22A1"
            });
            Entities.Add("&doublebarwedge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8966 },
                Characters = "\u2306"
            });
            Entities.Add("&downarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8595 },
                Characters = "\u2193"
            });
            Entities.Add("&downdownarrows;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8650 },
                Characters = "\u21CA"
            });
            Entities.Add("&downharpoonleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8643 },
                Characters = "\u21C3"
            });
            Entities.Add("&downharpoonright;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8642 },
                Characters = "\u21C2"
            });
            Entities.Add("&drbkarow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10512 },
                Characters = "\u2910"
            });
            Entities.Add("&drcorn;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8991 },
                Characters = "\u231F"
            });
            Entities.Add("&drcrop;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8972 },
                Characters = "\u230C"
            });
            Entities.Add("&dscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119993 },
                Characters = "\uD835\uDCB9"
            });
            Entities.Add("&dscy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1109 },
                Characters = "\u0455"
            });
            Entities.Add("&dsol;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10742 },
                Characters = "\u29F6"
            });
            Entities.Add("&dstrok;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 273 },
                Characters = "\u0111"
            });
            Entities.Add("&dtdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8945 },
                Characters = "\u22F1"
            });
            Entities.Add("&dtri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9663 },
                Characters = "\u25BF"
            });
            Entities.Add("&dtrif;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9662 },
                Characters = "\u25BE"
            });
            Entities.Add("&duarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8693 },
                Characters = "\u21F5"
            });
            Entities.Add("&duhar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10607 },
                Characters = "\u296F"
            });
            Entities.Add("&dwangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10662 },
                Characters = "\u29A6"
            });
            Entities.Add("&dzcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1119 },
                Characters = "\u045F"
            });
            Entities.Add("&dzigrarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10239 },
                Characters = "\u27FF"
            });
            Entities.Add("&eDDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10871 },
                Characters = "\u2A77"
            });
            Entities.Add("&eDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8785 },
                Characters = "\u2251"
            });
            Entities.Add("&eacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 233 },
                Characters = "\u00E9"
            });
            Entities.Add("&eacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 233 },
                Characters = "\u00E9"
            });
            Entities.Add("&easter;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10862 },
                Characters = "\u2A6E"
            });
            Entities.Add("&ecaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 283 },
                Characters = "\u011B"
            });
            Entities.Add("&ecir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8790 },
                Characters = "\u2256"
            });
            Entities.Add("&ecirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 234 },
                Characters = "\u00EA"
            });
            Entities.Add("&ecirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 234 },
                Characters = "\u00EA"
            });
            Entities.Add("&ecolon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8789 },
                Characters = "\u2255"
            });
            Entities.Add("&ecy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1101 },
                Characters = "\u044D"
            });
            Entities.Add("&edot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 279 },
                Characters = "\u0117"
            });
            Entities.Add("&ee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8519 },
                Characters = "\u2147"
            });
            Entities.Add("&efDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8786 },
                Characters = "\u2252"
            });
            Entities.Add("&efr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120098 },
                Characters = "\uD835\uDD22"
            });
            Entities.Add("&eg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10906 },
                Characters = "\u2A9A"
            });
            Entities.Add("&egrave", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 232 },
                Characters = "\u00E8"
            });
            Entities.Add("&egrave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 232 },
                Characters = "\u00E8"
            });
            Entities.Add("&egs;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10902 },
                Characters = "\u2A96"
            });
            Entities.Add("&egsdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10904 },
                Characters = "\u2A98"
            });
            Entities.Add("&el;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10905 },
                Characters = "\u2A99"
            });
            Entities.Add("&elinters;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9191 },
                Characters = "\u23E7"
            });
            Entities.Add("&ell;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8467 },
                Characters = "\u2113"
            });
            Entities.Add("&els;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10901 },
                Characters = "\u2A95"
            });
            Entities.Add("&elsdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10903 },
                Characters = "\u2A97"
            });
            Entities.Add("&emacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 275 },
                Characters = "\u0113"
            });
            Entities.Add("&empty;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8709 },
                Characters = "\u2205"
            });
            Entities.Add("&emptyset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8709 },
                Characters = "\u2205"
            });
            Entities.Add("&emptyv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8709 },
                Characters = "\u2205"
            });
            Entities.Add("&emsp13;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8196 },
                Characters = "\u2004"
            });
            Entities.Add("&emsp14;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8197 },
                Characters = "\u2005"
            });
            Entities.Add("&emsp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8195 },
                Characters = "\u2003"
            });
            Entities.Add("&eng;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 331 },
                Characters = "\u014B"
            });
            Entities.Add("&ensp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8194 },
                Characters = "\u2002"
            });
            Entities.Add("&eogon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 281 },
                Characters = "\u0119"
            });
            Entities.Add("&eopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120150 },
                Characters = "\uD835\uDD56"
            });
            Entities.Add("&epar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8917 },
                Characters = "\u22D5"
            });
            Entities.Add("&eparsl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10723 },
                Characters = "\u29E3"
            });
            Entities.Add("&eplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10865 },
                Characters = "\u2A71"
            });
            Entities.Add("&epsi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 949 },
                Characters = "\u03B5"
            });
            Entities.Add("&epsilon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 949 },
                Characters = "\u03B5"
            });
            Entities.Add("&epsiv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1013 },
                Characters = "\u03F5"
            });
            Entities.Add("&eqcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8790 },
                Characters = "\u2256"
            });
            Entities.Add("&eqcolon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8789 },
                Characters = "\u2255"
            });
            Entities.Add("&eqsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8770 },
                Characters = "\u2242"
            });
            Entities.Add("&eqslantgtr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10902 },
                Characters = "\u2A96"
            });
            Entities.Add("&eqslantless;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10901 },
                Characters = "\u2A95"
            });
            Entities.Add("&equals;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 61 },
                Characters = "\u003D"
            });
            Entities.Add("&equest;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8799 },
                Characters = "\u225F"
            });
            Entities.Add("&equiv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8801 },
                Characters = "\u2261"
            });
            Entities.Add("&equivDD;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10872 },
                Characters = "\u2A78"
            });
            Entities.Add("&eqvparsl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10725 },
                Characters = "\u29E5"
            });
            Entities.Add("&erDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8787 },
                Characters = "\u2253"
            });
            Entities.Add("&erarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10609 },
                Characters = "\u2971"
            });
            Entities.Add("&escr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8495 },
                Characters = "\u212F"
            });
            Entities.Add("&esdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8784 },
                Characters = "\u2250"
            });
            Entities.Add("&esim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8770 },
                Characters = "\u2242"
            });
            Entities.Add("&eta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 951 },
                Characters = "\u03B7"
            });
            Entities.Add("&eth", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 240 },
                Characters = "\u00F0"
            });
            Entities.Add("&eth;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 240 },
                Characters = "\u00F0"
            });
            Entities.Add("&euml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 235 },
                Characters = "\u00EB"
            });
            Entities.Add("&euml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 235 },
                Characters = "\u00EB"
            });
            Entities.Add("&euro;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8364 },
                Characters = "\u20AC"
            });
            Entities.Add("&excl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 33 },
                Characters = "\u0021"
            });
            Entities.Add("&exist;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8707 },
                Characters = "\u2203"
            });
            Entities.Add("&expectation;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8496 },
                Characters = "\u2130"
            });
            Entities.Add("&exponentiale;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8519 },
                Characters = "\u2147"
            });
            Entities.Add("&fallingdotseq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8786 },
                Characters = "\u2252"
            });
            Entities.Add("&fcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1092 },
                Characters = "\u0444"
            });
            Entities.Add("&female;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9792 },
                Characters = "\u2640"
            });
            Entities.Add("&ffilig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 64259 },
                Characters = "\uFB03"
            });
            Entities.Add("&fflig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 64256 },
                Characters = "\uFB00"
            });
            Entities.Add("&ffllig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 64260 },
                Characters = "\uFB04"
            });
            Entities.Add("&ffr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120099 },
                Characters = "\uD835\uDD23"
            });
            Entities.Add("&filig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 64257 },
                Characters = "\uFB01"
            });
            Entities.Add("&fjlig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 102, 106 },
                Characters = "\u0066\u006A"
            });
            Entities.Add("&flat;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9837 },
                Characters = "\u266D"
            });
            Entities.Add("&fllig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 64258 },
                Characters = "\uFB02"
            });
            Entities.Add("&fltns;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9649 },
                Characters = "\u25B1"
            });
            Entities.Add("&fnof;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 402 },
                Characters = "\u0192"
            });
            Entities.Add("&fopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120151 },
                Characters = "\uD835\uDD57"
            });
            Entities.Add("&forall;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8704 },
                Characters = "\u2200"
            });
            Entities.Add("&fork;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8916 },
                Characters = "\u22D4"
            });
            Entities.Add("&forkv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10969 },
                Characters = "\u2AD9"
            });
            Entities.Add("&fpartint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10765 },
                Characters = "\u2A0D"
            });
            Entities.Add("&frac12", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 189 },
                Characters = "\u00BD"
            });
            Entities.Add("&frac12;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 189 },
                Characters = "\u00BD"
            });
            Entities.Add("&frac13;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8531 },
                Characters = "\u2153"
            });
            Entities.Add("&frac14", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 188 },
                Characters = "\u00BC"
            });
            Entities.Add("&frac14;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 188 },
                Characters = "\u00BC"
            });
            Entities.Add("&frac15;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8533 },
                Characters = "\u2155"
            });
            Entities.Add("&frac16;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8537 },
                Characters = "\u2159"
            });
            Entities.Add("&frac18;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8539 },
                Characters = "\u215B"
            });
            Entities.Add("&frac23;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8532 },
                Characters = "\u2154"
            });
            Entities.Add("&frac25;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8534 },
                Characters = "\u2156"
            });
            Entities.Add("&frac34", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 190 },
                Characters = "\u00BE"
            });
            Entities.Add("&frac34;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 190 },
                Characters = "\u00BE"
            });
            Entities.Add("&frac35;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8535 },
                Characters = "\u2157"
            });
            Entities.Add("&frac38;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8540 },
                Characters = "\u215C"
            });
            Entities.Add("&frac45;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8536 },
                Characters = "\u2158"
            });
            Entities.Add("&frac56;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8538 },
                Characters = "\u215A"
            });
            Entities.Add("&frac58;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8541 },
                Characters = "\u215D"
            });
            Entities.Add("&frac78;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8542 },
                Characters = "\u215E"
            });
            Entities.Add("&frasl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8260 },
                Characters = "\u2044"
            });
            Entities.Add("&frown;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8994 },
                Characters = "\u2322"
            });
            Entities.Add("&fscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119995 },
                Characters = "\uD835\uDCBB"
            });
            Entities.Add("&gE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8807 },
                Characters = "\u2267"
            });
            Entities.Add("&gEl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10892 },
                Characters = "\u2A8C"
            });
            Entities.Add("&gacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 501 },
                Characters = "\u01F5"
            });
            Entities.Add("&gamma;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 947 },
                Characters = "\u03B3"
            });
            Entities.Add("&gammad;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 989 },
                Characters = "\u03DD"
            });
            Entities.Add("&gap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10886 },
                Characters = "\u2A86"
            });
            Entities.Add("&gbreve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 287 },
                Characters = "\u011F"
            });
            Entities.Add("&gcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 285 },
                Characters = "\u011D"
            });
            Entities.Add("&gcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1075 },
                Characters = "\u0433"
            });
            Entities.Add("&gdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 289 },
                Characters = "\u0121"
            });
            Entities.Add("&ge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8805 },
                Characters = "\u2265"
            });
            Entities.Add("&gel;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8923 },
                Characters = "\u22DB"
            });
            Entities.Add("&geq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8805 },
                Characters = "\u2265"
            });
            Entities.Add("&geqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8807 },
                Characters = "\u2267"
            });
            Entities.Add("&geqslant;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10878 },
                Characters = "\u2A7E"
            });
            Entities.Add("&ges;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10878 },
                Characters = "\u2A7E"
            });
            Entities.Add("&gescc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10921 },
                Characters = "\u2AA9"
            });
            Entities.Add("&gesdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10880 },
                Characters = "\u2A80"
            });
            Entities.Add("&gesdoto;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10882 },
                Characters = "\u2A82"
            });
            Entities.Add("&gesdotol;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10884 },
                Characters = "\u2A84"
            });
            Entities.Add("&gesl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8923, 65024 },
                Characters = "\u22DB\uFE00"
            });
            Entities.Add("&gesles;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10900 },
                Characters = "\u2A94"
            });
            Entities.Add("&gfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120100 },
                Characters = "\uD835\uDD24"
            });
            Entities.Add("&gg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8811 },
                Characters = "\u226B"
            });
            Entities.Add("&ggg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8921 },
                Characters = "\u22D9"
            });
            Entities.Add("&gimel;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8503 },
                Characters = "\u2137"
            });
            Entities.Add("&gjcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1107 },
                Characters = "\u0453"
            });
            Entities.Add("&gl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8823 },
                Characters = "\u2277"
            });
            Entities.Add("&glE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10898 },
                Characters = "\u2A92"
            });
            Entities.Add("&gla;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10917 },
                Characters = "\u2AA5"
            });
            Entities.Add("&glj;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10916 },
                Characters = "\u2AA4"
            });
            Entities.Add("&gnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8809 },
                Characters = "\u2269"
            });
            Entities.Add("&gnap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10890 },
                Characters = "\u2A8A"
            });
            Entities.Add("&gnapprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10890 },
                Characters = "\u2A8A"
            });
            Entities.Add("&gne;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10888 },
                Characters = "\u2A88"
            });
            Entities.Add("&gneq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10888 },
                Characters = "\u2A88"
            });
            Entities.Add("&gneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8809 },
                Characters = "\u2269"
            });
            Entities.Add("&gnsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8935 },
                Characters = "\u22E7"
            });
            Entities.Add("&gopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120152 },
                Characters = "\uD835\uDD58"
            });
            Entities.Add("&grave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 96 },
                Characters = "\u0060"
            });
            Entities.Add("&gscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8458 },
                Characters = "\u210A"
            });
            Entities.Add("&gsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8819 },
                Characters = "\u2273"
            });
            Entities.Add("&gsime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10894 },
                Characters = "\u2A8E"
            });
            Entities.Add("&gsiml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10896 },
                Characters = "\u2A90"
            });
            Entities.Add("&gt", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 62 },
                Characters = "\u003E"
            });
            Entities.Add("&gt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 62 },
                Characters = "\u003E"
            });
            Entities.Add("&gtcc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10919 },
                Characters = "\u2AA7"
            });
            Entities.Add("&gtcir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10874 },
                Characters = "\u2A7A"
            });
            Entities.Add("&gtdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8919 },
                Characters = "\u22D7"
            });
            Entities.Add("&gtlPar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10645 },
                Characters = "\u2995"
            });
            Entities.Add("&gtquest;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10876 },
                Characters = "\u2A7C"
            });
            Entities.Add("&gtrapprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10886 },
                Characters = "\u2A86"
            });
            Entities.Add("&gtrarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10616 },
                Characters = "\u2978"
            });
            Entities.Add("&gtrdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8919 },
                Characters = "\u22D7"
            });
            Entities.Add("&gtreqless;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8923 },
                Characters = "\u22DB"
            });
            Entities.Add("&gtreqqless;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10892 },
                Characters = "\u2A8C"
            });
            Entities.Add("&gtrless;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8823 },
                Characters = "\u2277"
            });
            Entities.Add("&gtrsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8819 },
                Characters = "\u2273"
            });
            Entities.Add("&gvertneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8809, 65024 },
                Characters = "\u2269\uFE00"
            });
            Entities.Add("&gvnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8809, 65024 },
                Characters = "\u2269\uFE00"
            });
            Entities.Add("&hArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8660 },
                Characters = "\u21D4"
            });
            Entities.Add("&hairsp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8202 },
                Characters = "\u200A"
            });
            Entities.Add("&half;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 189 },
                Characters = "\u00BD"
            });
            Entities.Add("&hamilt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8459 },
                Characters = "\u210B"
            });
            Entities.Add("&hardcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1098 },
                Characters = "\u044A"
            });
            Entities.Add("&harr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8596 },
                Characters = "\u2194"
            });
            Entities.Add("&harrcir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10568 },
                Characters = "\u2948"
            });
            Entities.Add("&harrw;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8621 },
                Characters = "\u21AD"
            });
            Entities.Add("&hbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8463 },
                Characters = "\u210F"
            });
            Entities.Add("&hcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 293 },
                Characters = "\u0125"
            });
            Entities.Add("&hearts;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9829 },
                Characters = "\u2665"
            });
            Entities.Add("&heartsuit;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9829 },
                Characters = "\u2665"
            });
            Entities.Add("&hellip;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8230 },
                Characters = "\u2026"
            });
            Entities.Add("&hercon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8889 },
                Characters = "\u22B9"
            });
            Entities.Add("&hfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120101 },
                Characters = "\uD835\uDD25"
            });
            Entities.Add("&hksearow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10533 },
                Characters = "\u2925"
            });
            Entities.Add("&hkswarow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10534 },
                Characters = "\u2926"
            });
            Entities.Add("&hoarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8703 },
                Characters = "\u21FF"
            });
            Entities.Add("&homtht;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8763 },
                Characters = "\u223B"
            });
            Entities.Add("&hookleftarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8617 },
                Characters = "\u21A9"
            });
            Entities.Add("&hookrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8618 },
                Characters = "\u21AA"
            });
            Entities.Add("&hopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120153 },
                Characters = "\uD835\uDD59"
            });
            Entities.Add("&horbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8213 },
                Characters = "\u2015"
            });
            Entities.Add("&hscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119997 },
                Characters = "\uD835\uDCBD"
            });
            Entities.Add("&hslash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8463 },
                Characters = "\u210F"
            });
            Entities.Add("&hstrok;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 295 },
                Characters = "\u0127"
            });
            Entities.Add("&hybull;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8259 },
                Characters = "\u2043"
            });
            Entities.Add("&hyphen;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8208 },
                Characters = "\u2010"
            });
            Entities.Add("&iacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 237 },
                Characters = "\u00ED"
            });
            Entities.Add("&iacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 237 },
                Characters = "\u00ED"
            });
            Entities.Add("&ic;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8291 },
                Characters = "\u2063"
            });
            Entities.Add("&icirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 238 },
                Characters = "\u00EE"
            });
            Entities.Add("&icirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 238 },
                Characters = "\u00EE"
            });
            Entities.Add("&icy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1080 },
                Characters = "\u0438"
            });
            Entities.Add("&iecy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1077 },
                Characters = "\u0435"
            });
            Entities.Add("&iexcl", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 161 },
                Characters = "\u00A1"
            });
            Entities.Add("&iexcl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 161 },
                Characters = "\u00A1"
            });
            Entities.Add("&iff;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8660 },
                Characters = "\u21D4"
            });
            Entities.Add("&ifr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120102 },
                Characters = "\uD835\uDD26"
            });
            Entities.Add("&igrave", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 236 },
                Characters = "\u00EC"
            });
            Entities.Add("&igrave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 236 },
                Characters = "\u00EC"
            });
            Entities.Add("&ii;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8520 },
                Characters = "\u2148"
            });
            Entities.Add("&iiiint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10764 },
                Characters = "\u2A0C"
            });
            Entities.Add("&iiint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8749 },
                Characters = "\u222D"
            });
            Entities.Add("&iinfin;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10716 },
                Characters = "\u29DC"
            });
            Entities.Add("&iiota;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8489 },
                Characters = "\u2129"
            });
            Entities.Add("&ijlig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 307 },
                Characters = "\u0133"
            });
            Entities.Add("&imacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 299 },
                Characters = "\u012B"
            });
            Entities.Add("&image;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8465 },
                Characters = "\u2111"
            });
            Entities.Add("&imagline;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8464 },
                Characters = "\u2110"
            });
            Entities.Add("&imagpart;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8465 },
                Characters = "\u2111"
            });
            Entities.Add("&imath;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 305 },
                Characters = "\u0131"
            });
            Entities.Add("&imof;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8887 },
                Characters = "\u22B7"
            });
            Entities.Add("&imped;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 437 },
                Characters = "\u01B5"
            });
            Entities.Add("&in;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8712 },
                Characters = "\u2208"
            });
            Entities.Add("&incare;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8453 },
                Characters = "\u2105"
            });
            Entities.Add("&infin;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8734 },
                Characters = "\u221E"
            });
            Entities.Add("&infintie;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10717 },
                Characters = "\u29DD"
            });
            Entities.Add("&inodot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 305 },
                Characters = "\u0131"
            });
            Entities.Add("&int;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8747 },
                Characters = "\u222B"
            });
            Entities.Add("&intcal;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8890 },
                Characters = "\u22BA"
            });
            Entities.Add("&integers;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8484 },
                Characters = "\u2124"
            });
            Entities.Add("&intercal;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8890 },
                Characters = "\u22BA"
            });
            Entities.Add("&intlarhk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10775 },
                Characters = "\u2A17"
            });
            Entities.Add("&intprod;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10812 },
                Characters = "\u2A3C"
            });
            Entities.Add("&iocy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1105 },
                Characters = "\u0451"
            });
            Entities.Add("&iogon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 303 },
                Characters = "\u012F"
            });
            Entities.Add("&iopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120154 },
                Characters = "\uD835\uDD5A"
            });
            Entities.Add("&iota;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 953 },
                Characters = "\u03B9"
            });
            Entities.Add("&iprod;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10812 },
                Characters = "\u2A3C"
            });
            Entities.Add("&iquest", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 191 },
                Characters = "\u00BF"
            });
            Entities.Add("&iquest;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 191 },
                Characters = "\u00BF"
            });
            Entities.Add("&iscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119998 },
                Characters = "\uD835\uDCBE"
            });
            Entities.Add("&isin;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8712 },
                Characters = "\u2208"
            });
            Entities.Add("&isinE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8953 },
                Characters = "\u22F9"
            });
            Entities.Add("&isindot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8949 },
                Characters = "\u22F5"
            });
            Entities.Add("&isins;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8948 },
                Characters = "\u22F4"
            });
            Entities.Add("&isinsv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8947 },
                Characters = "\u22F3"
            });
            Entities.Add("&isinv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8712 },
                Characters = "\u2208"
            });
            Entities.Add("&it;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8290 },
                Characters = "\u2062"
            });
            Entities.Add("&itilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 297 },
                Characters = "\u0129"
            });
            Entities.Add("&iukcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1110 },
                Characters = "\u0456"
            });
            Entities.Add("&iuml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 239 },
                Characters = "\u00EF"
            });
            Entities.Add("&iuml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 239 },
                Characters = "\u00EF"
            });
            Entities.Add("&jcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 309 },
                Characters = "\u0135"
            });
            Entities.Add("&jcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1081 },
                Characters = "\u0439"
            });
            Entities.Add("&jfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120103 },
                Characters = "\uD835\uDD27"
            });
            Entities.Add("&jmath;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 567 },
                Characters = "\u0237"
            });
            Entities.Add("&jopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120155 },
                Characters = "\uD835\uDD5B"
            });
            Entities.Add("&jscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 119999 },
                Characters = "\uD835\uDCBF"
            });
            Entities.Add("&jsercy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1112 },
                Characters = "\u0458"
            });
            Entities.Add("&jukcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1108 },
                Characters = "\u0454"
            });
            Entities.Add("&kappa;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 954 },
                Characters = "\u03BA"
            });
            Entities.Add("&kappav;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1008 },
                Characters = "\u03F0"
            });
            Entities.Add("&kcedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 311 },
                Characters = "\u0137"
            });
            Entities.Add("&kcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1082 },
                Characters = "\u043A"
            });
            Entities.Add("&kfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120104 },
                Characters = "\uD835\uDD28"
            });
            Entities.Add("&kgreen;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 312 },
                Characters = "\u0138"
            });
            Entities.Add("&khcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1093 },
                Characters = "\u0445"
            });
            Entities.Add("&kjcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1116 },
                Characters = "\u045C"
            });
            Entities.Add("&kopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120156 },
                Characters = "\uD835\uDD5C"
            });
            Entities.Add("&kscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120000 },
                Characters = "\uD835\uDCC0"
            });
            Entities.Add("&lAarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8666 },
                Characters = "\u21DA"
            });
            Entities.Add("&lArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8656 },
                Characters = "\u21D0"
            });
            Entities.Add("&lAtail;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10523 },
                Characters = "\u291B"
            });
            Entities.Add("&lBarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10510 },
                Characters = "\u290E"
            });
            Entities.Add("&lE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8806 },
                Characters = "\u2266"
            });
            Entities.Add("&lEg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10891 },
                Characters = "\u2A8B"
            });
            Entities.Add("&lHar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10594 },
                Characters = "\u2962"
            });
            Entities.Add("&lacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 314 },
                Characters = "\u013A"
            });
            Entities.Add("&laemptyv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10676 },
                Characters = "\u29B4"
            });
            Entities.Add("&lagran;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8466 },
                Characters = "\u2112"
            });
            Entities.Add("&lambda;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 955 },
                Characters = "\u03BB"
            });
            Entities.Add("&lang;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10216 },
                Characters = "\u27E8"
            });
            Entities.Add("&langd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10641 },
                Characters = "\u2991"
            });
            Entities.Add("&langle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10216 },
                Characters = "\u27E8"
            });
            Entities.Add("&lap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10885 },
                Characters = "\u2A85"
            });
            Entities.Add("&laquo", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 171 },
                Characters = "\u00AB"
            });
            Entities.Add("&laquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 171 },
                Characters = "\u00AB"
            });
            Entities.Add("&larr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8592 },
                Characters = "\u2190"
            });
            Entities.Add("&larrb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8676 },
                Characters = "\u21E4"
            });
            Entities.Add("&larrbfs;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10527 },
                Characters = "\u291F"
            });
            Entities.Add("&larrfs;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10525 },
                Characters = "\u291D"
            });
            Entities.Add("&larrhk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8617 },
                Characters = "\u21A9"
            });
            Entities.Add("&larrlp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8619 },
                Characters = "\u21AB"
            });
            Entities.Add("&larrpl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10553 },
                Characters = "\u2939"
            });
            Entities.Add("&larrsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10611 },
                Characters = "\u2973"
            });
            Entities.Add("&larrtl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8610 },
                Characters = "\u21A2"
            });
            Entities.Add("&lat;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10923 },
                Characters = "\u2AAB"
            });
            Entities.Add("&latail;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10521 },
                Characters = "\u2919"
            });
            Entities.Add("&late;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10925 },
                Characters = "\u2AAD"
            });
            Entities.Add("&lates;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10925, 65024 },
                Characters = "\u2AAD\uFE00"
            });
            Entities.Add("&lbarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10508 },
                Characters = "\u290C"
            });
            Entities.Add("&lbbrk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10098 },
                Characters = "\u2772"
            });
            Entities.Add("&lbrace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 123 },
                Characters = "\u007B"
            });
            Entities.Add("&lbrack;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 91 },
                Characters = "\u005B"
            });
            Entities.Add("&lbrke;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10635 },
                Characters = "\u298B"
            });
            Entities.Add("&lbrksld;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10639 },
                Characters = "\u298F"
            });
            Entities.Add("&lbrkslu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10637 },
                Characters = "\u298D"
            });
            Entities.Add("&lcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 318 },
                Characters = "\u013E"
            });
            Entities.Add("&lcedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 316 },
                Characters = "\u013C"
            });
            Entities.Add("&lceil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8968 },
                Characters = "\u2308"
            });
            Entities.Add("&lcub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 123 },
                Characters = "\u007B"
            });
            Entities.Add("&lcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1083 },
                Characters = "\u043B"
            });
            Entities.Add("&ldca;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10550 },
                Characters = "\u2936"
            });
            Entities.Add("&ldquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8220 },
                Characters = "\u201C"
            });
            Entities.Add("&ldquor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8222 },
                Characters = "\u201E"
            });
            Entities.Add("&ldrdhar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10599 },
                Characters = "\u2967"
            });
            Entities.Add("&ldrushar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10571 },
                Characters = "\u294B"
            });
            Entities.Add("&ldsh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8626 },
                Characters = "\u21B2"
            });
            Entities.Add("&le;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8804 },
                Characters = "\u2264"
            });
            Entities.Add("&leftarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8592 },
                Characters = "\u2190"
            });
            Entities.Add("&leftarrowtail;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8610 },
                Characters = "\u21A2"
            });
            Entities.Add("&leftharpoondown;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8637 },
                Characters = "\u21BD"
            });
            Entities.Add("&leftharpoonup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8636 },
                Characters = "\u21BC"
            });
            Entities.Add("&leftleftarrows;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8647 },
                Characters = "\u21C7"
            });
            Entities.Add("&leftrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8596 },
                Characters = "\u2194"
            });
            Entities.Add("&leftrightarrows;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8646 },
                Characters = "\u21C6"
            });
            Entities.Add("&leftrightharpoons;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8651 },
                Characters = "\u21CB"
            });
            Entities.Add("&leftrightsquigarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8621 },
                Characters = "\u21AD"
            });
            Entities.Add("&leftthreetimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8907 },
                Characters = "\u22CB"
            });
            Entities.Add("&leg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8922 },
                Characters = "\u22DA"
            });
            Entities.Add("&leq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8804 },
                Characters = "\u2264"
            });
            Entities.Add("&leqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8806 },
                Characters = "\u2266"
            });
            Entities.Add("&leqslant;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10877 },
                Characters = "\u2A7D"
            });
            Entities.Add("&les;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10877 },
                Characters = "\u2A7D"
            });
            Entities.Add("&lescc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10920 },
                Characters = "\u2AA8"
            });
            Entities.Add("&lesdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10879 },
                Characters = "\u2A7F"
            });
            Entities.Add("&lesdoto;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10881 },
                Characters = "\u2A81"
            });
            Entities.Add("&lesdotor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10883 },
                Characters = "\u2A83"
            });
            Entities.Add("&lesg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8922, 65024 },
                Characters = "\u22DA\uFE00"
            });
            Entities.Add("&lesges;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10899 },
                Characters = "\u2A93"
            });
            Entities.Add("&lessapprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10885 },
                Characters = "\u2A85"
            });
            Entities.Add("&lessdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8918 },
                Characters = "\u22D6"
            });
            Entities.Add("&lesseqgtr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8922 },
                Characters = "\u22DA"
            });
            Entities.Add("&lesseqqgtr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10891 },
                Characters = "\u2A8B"
            });
            Entities.Add("&lessgtr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8822 },
                Characters = "\u2276"
            });
            Entities.Add("&lesssim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8818 },
                Characters = "\u2272"
            });
            Entities.Add("&lfisht;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10620 },
                Characters = "\u297C"
            });
            Entities.Add("&lfloor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8970 },
                Characters = "\u230A"
            });
            Entities.Add("&lfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120105 },
                Characters = "\uD835\uDD29"
            });
            Entities.Add("&lg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8822 },
                Characters = "\u2276"
            });
            Entities.Add("&lgE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10897 },
                Characters = "\u2A91"
            });
            Entities.Add("&lhard;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8637 },
                Characters = "\u21BD"
            });
            Entities.Add("&lharu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8636 },
                Characters = "\u21BC"
            });
            Entities.Add("&lharul;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10602 },
                Characters = "\u296A"
            });
            Entities.Add("&lhblk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9604 },
                Characters = "\u2584"
            });
            Entities.Add("&ljcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1113 },
                Characters = "\u0459"
            });
            Entities.Add("&ll;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8810 },
                Characters = "\u226A"
            });
            Entities.Add("&llarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8647 },
                Characters = "\u21C7"
            });
            Entities.Add("&llcorner;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8990 },
                Characters = "\u231E"
            });
            Entities.Add("&llhard;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10603 },
                Characters = "\u296B"
            });
            Entities.Add("&lltri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9722 },
                Characters = "\u25FA"
            });
            Entities.Add("&lmidot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 320 },
                Characters = "\u0140"
            });
            Entities.Add("&lmoust;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9136 },
                Characters = "\u23B0"
            });
            Entities.Add("&lmoustache;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9136 },
                Characters = "\u23B0"
            });
            Entities.Add("&lnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8808 },
                Characters = "\u2268"
            });
            Entities.Add("&lnap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10889 },
                Characters = "\u2A89"
            });
            Entities.Add("&lnapprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10889 },
                Characters = "\u2A89"
            });
            Entities.Add("&lne;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10887 },
                Characters = "\u2A87"
            });
            Entities.Add("&lneq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10887 },
                Characters = "\u2A87"
            });
            Entities.Add("&lneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8808 },
                Characters = "\u2268"
            });
            Entities.Add("&lnsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8934 },
                Characters = "\u22E6"
            });
            Entities.Add("&loang;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10220 },
                Characters = "\u27EC"
            });
            Entities.Add("&loarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8701 },
                Characters = "\u21FD"
            });
            Entities.Add("&lobrk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10214 },
                Characters = "\u27E6"
            });
            Entities.Add("&longleftarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10229 },
                Characters = "\u27F5"
            });
            Entities.Add("&longleftrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10231 },
                Characters = "\u27F7"
            });
            Entities.Add("&longmapsto;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10236 },
                Characters = "\u27FC"
            });
            Entities.Add("&longrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10230 },
                Characters = "\u27F6"
            });
            Entities.Add("&looparrowleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8619 },
                Characters = "\u21AB"
            });
            Entities.Add("&looparrowright;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8620 },
                Characters = "\u21AC"
            });
            Entities.Add("&lopar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10629 },
                Characters = "\u2985"
            });
            Entities.Add("&lopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120157 },
                Characters = "\uD835\uDD5D"
            });
            Entities.Add("&loplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10797 },
                Characters = "\u2A2D"
            });
            Entities.Add("&lotimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10804 },
                Characters = "\u2A34"
            });
            Entities.Add("&lowast;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8727 },
                Characters = "\u2217"
            });
            Entities.Add("&lowbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 95 },
                Characters = "\u005F"
            });
            Entities.Add("&loz;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9674 },
                Characters = "\u25CA"
            });
            Entities.Add("&lozenge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9674 },
                Characters = "\u25CA"
            });
            Entities.Add("&lozf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10731 },
                Characters = "\u29EB"
            });
            Entities.Add("&lpar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 40 },
                Characters = "\u0028"
            });
            Entities.Add("&lparlt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10643 },
                Characters = "\u2993"
            });
            Entities.Add("&lrarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8646 },
                Characters = "\u21C6"
            });
            Entities.Add("&lrcorner;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8991 },
                Characters = "\u231F"
            });
            Entities.Add("&lrhar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8651 },
                Characters = "\u21CB"
            });
            Entities.Add("&lrhard;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10605 },
                Characters = "\u296D"
            });
            Entities.Add("&lrm;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8206 },
                Characters = "\u200E"
            });
            Entities.Add("&lrtri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8895 },
                Characters = "\u22BF"
            });
            Entities.Add("&lsaquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8249 },
                Characters = "\u2039"
            });
            Entities.Add("&lscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120001 },
                Characters = "\uD835\uDCC1"
            });
            Entities.Add("&lsh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8624 },
                Characters = "\u21B0"
            });
            Entities.Add("&lsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8818 },
                Characters = "\u2272"
            });
            Entities.Add("&lsime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10893 },
                Characters = "\u2A8D"
            });
            Entities.Add("&lsimg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10895 },
                Characters = "\u2A8F"
            });
            Entities.Add("&lsqb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 91 },
                Characters = "\u005B"
            });
            Entities.Add("&lsquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8216 },
                Characters = "\u2018"
            });
            Entities.Add("&lsquor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8218 },
                Characters = "\u201A"
            });
            Entities.Add("&lstrok;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 322 },
                Characters = "\u0142"
            });
            Entities.Add("&lt", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 60 },
                Characters = "\u003C"
            });
            Entities.Add("&lt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 60 },
                Characters = "\u003C"
            });
            Entities.Add("&ltcc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10918 },
                Characters = "\u2AA6"
            });
            Entities.Add("&ltcir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10873 },
                Characters = "\u2A79"
            });
            Entities.Add("&ltdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8918 },
                Characters = "\u22D6"
            });
            Entities.Add("&lthree;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8907 },
                Characters = "\u22CB"
            });
            Entities.Add("&ltimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8905 },
                Characters = "\u22C9"
            });
            Entities.Add("&ltlarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10614 },
                Characters = "\u2976"
            });
            Entities.Add("&ltquest;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10875 },
                Characters = "\u2A7B"
            });
            Entities.Add("&ltrPar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10646 },
                Characters = "\u2996"
            });
            Entities.Add("&ltri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9667 },
                Characters = "\u25C3"
            });
            Entities.Add("&ltrie;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8884 },
                Characters = "\u22B4"
            });
            Entities.Add("&ltrif;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9666 },
                Characters = "\u25C2"
            });
            Entities.Add("&lurdshar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10570 },
                Characters = "\u294A"
            });
            Entities.Add("&luruhar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10598 },
                Characters = "\u2966"
            });
            Entities.Add("&lvertneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8808, 65024 },
                Characters = "\u2268\uFE00"
            });
            Entities.Add("&lvnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8808, 65024 },
                Characters = "\u2268\uFE00"
            });
            Entities.Add("&mDDot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8762 },
                Characters = "\u223A"
            });
            Entities.Add("&macr", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 175 },
                Characters = "\u00AF"
            });
            Entities.Add("&macr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 175 },
                Characters = "\u00AF"
            });
            Entities.Add("&male;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9794 },
                Characters = "\u2642"
            });
            Entities.Add("&malt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10016 },
                Characters = "\u2720"
            });
            Entities.Add("&maltese;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10016 },
                Characters = "\u2720"
            });
            Entities.Add("&map;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8614 },
                Characters = "\u21A6"
            });
            Entities.Add("&mapsto;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8614 },
                Characters = "\u21A6"
            });
            Entities.Add("&mapstodown;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8615 },
                Characters = "\u21A7"
            });
            Entities.Add("&mapstoleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8612 },
                Characters = "\u21A4"
            });
            Entities.Add("&mapstoup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8613 },
                Characters = "\u21A5"
            });
            Entities.Add("&marker;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9646 },
                Characters = "\u25AE"
            });
            Entities.Add("&mcomma;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10793 },
                Characters = "\u2A29"
            });
            Entities.Add("&mcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1084 },
                Characters = "\u043C"
            });
            Entities.Add("&mdash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8212 },
                Characters = "\u2014"
            });
            Entities.Add("&measuredangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8737 },
                Characters = "\u2221"
            });
            Entities.Add("&mfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120106 },
                Characters = "\uD835\uDD2A"
            });
            Entities.Add("&mho;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8487 },
                Characters = "\u2127"
            });
            Entities.Add("&micro", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 181 },
                Characters = "\u00B5"
            });
            Entities.Add("&micro;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 181 },
                Characters = "\u00B5"
            });
            Entities.Add("&mid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8739 },
                Characters = "\u2223"
            });
            Entities.Add("&midast;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 42 },
                Characters = "\u002A"
            });
            Entities.Add("&midcir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10992 },
                Characters = "\u2AF0"
            });
            Entities.Add("&middot", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 183 },
                Characters = "\u00B7"
            });
            Entities.Add("&middot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 183 },
                Characters = "\u00B7"
            });
            Entities.Add("&minus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8722 },
                Characters = "\u2212"
            });
            Entities.Add("&minusb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8863 },
                Characters = "\u229F"
            });
            Entities.Add("&minusd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8760 },
                Characters = "\u2238"
            });
            Entities.Add("&minusdu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10794 },
                Characters = "\u2A2A"
            });
            Entities.Add("&mlcp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10971 },
                Characters = "\u2ADB"
            });
            Entities.Add("&mldr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8230 },
                Characters = "\u2026"
            });
            Entities.Add("&mnplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8723 },
                Characters = "\u2213"
            });
            Entities.Add("&models;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8871 },
                Characters = "\u22A7"
            });
            Entities.Add("&mopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120158 },
                Characters = "\uD835\uDD5E"
            });
            Entities.Add("&mp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8723 },
                Characters = "\u2213"
            });
            Entities.Add("&mscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120002 },
                Characters = "\uD835\uDCC2"
            });
            Entities.Add("&mstpos;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8766 },
                Characters = "\u223E"
            });
            Entities.Add("&mu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 956 },
                Characters = "\u03BC"
            });
            Entities.Add("&multimap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8888 },
                Characters = "\u22B8"
            });
            Entities.Add("&mumap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8888 },
                Characters = "\u22B8"
            });
            Entities.Add("&nGg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8921, 824 },
                Characters = "\u22D9\u0338"
            });
            Entities.Add("&nGt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8811, 8402 },
                Characters = "\u226B\u20D2"
            });
            Entities.Add("&nGtv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8811, 824 },
                Characters = "\u226B\u0338"
            });
            Entities.Add("&nLeftarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8653 },
                Characters = "\u21CD"
            });
            Entities.Add("&nLeftrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8654 },
                Characters = "\u21CE"
            });
            Entities.Add("&nLl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8920, 824 },
                Characters = "\u22D8\u0338"
            });
            Entities.Add("&nLt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8810, 8402 },
                Characters = "\u226A\u20D2"
            });
            Entities.Add("&nLtv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8810, 824 },
                Characters = "\u226A\u0338"
            });
            Entities.Add("&nRightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8655 },
                Characters = "\u21CF"
            });
            Entities.Add("&nVDash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8879 },
                Characters = "\u22AF"
            });
            Entities.Add("&nVdash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8878 },
                Characters = "\u22AE"
            });
            Entities.Add("&nabla;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8711 },
                Characters = "\u2207"
            });
            Entities.Add("&nacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 324 },
                Characters = "\u0144"
            });
            Entities.Add("&nang;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8736, 8402 },
                Characters = "\u2220\u20D2"
            });
            Entities.Add("&nap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8777 },
                Characters = "\u2249"
            });
            Entities.Add("&napE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10864, 824 },
                Characters = "\u2A70\u0338"
            });
            Entities.Add("&napid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8779, 824 },
                Characters = "\u224B\u0338"
            });
            Entities.Add("&napos;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 329 },
                Characters = "\u0149"
            });
            Entities.Add("&napprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8777 },
                Characters = "\u2249"
            });
            Entities.Add("&natur;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9838 },
                Characters = "\u266E"
            });
            Entities.Add("&natural;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9838 },
                Characters = "\u266E"
            });
            Entities.Add("&naturals;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8469 },
                Characters = "\u2115"
            });
            Entities.Add("&nbsp", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 160 },
                Characters = "\u00A0"
            });
            Entities.Add("&nbsp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 160 },
                Characters = "\u00A0"
            });
            Entities.Add("&nbump;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8782, 824 },
                Characters = "\u224E\u0338"
            });
            Entities.Add("&nbumpe;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8783, 824 },
                Characters = "\u224F\u0338"
            });
            Entities.Add("&ncap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10819 },
                Characters = "\u2A43"
            });
            Entities.Add("&ncaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 328 },
                Characters = "\u0148"
            });
            Entities.Add("&ncedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 326 },
                Characters = "\u0146"
            });
            Entities.Add("&ncong;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8775 },
                Characters = "\u2247"
            });
            Entities.Add("&ncongdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10861, 824 },
                Characters = "\u2A6D\u0338"
            });
            Entities.Add("&ncup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10818 },
                Characters = "\u2A42"
            });
            Entities.Add("&ncy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1085 },
                Characters = "\u043D"
            });
            Entities.Add("&ndash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8211 },
                Characters = "\u2013"
            });
            Entities.Add("&ne;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8800 },
                Characters = "\u2260"
            });
            Entities.Add("&neArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8663 },
                Characters = "\u21D7"
            });
            Entities.Add("&nearhk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10532 },
                Characters = "\u2924"
            });
            Entities.Add("&nearr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8599 },
                Characters = "\u2197"
            });
            Entities.Add("&nearrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8599 },
                Characters = "\u2197"
            });
            Entities.Add("&nedot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8784, 824 },
                Characters = "\u2250\u0338"
            });
            Entities.Add("&nequiv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8802 },
                Characters = "\u2262"
            });
            Entities.Add("&nesear;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10536 },
                Characters = "\u2928"
            });
            Entities.Add("&nesim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8770, 824 },
                Characters = "\u2242\u0338"
            });
            Entities.Add("&nexist;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8708 },
                Characters = "\u2204"
            });
            Entities.Add("&nexists;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8708 },
                Characters = "\u2204"
            });
            Entities.Add("&nfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120107 },
                Characters = "\uD835\uDD2B"
            });
            Entities.Add("&ngE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8807, 824 },
                Characters = "\u2267\u0338"
            });
            Entities.Add("&nge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8817 },
                Characters = "\u2271"
            });
            Entities.Add("&ngeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8817 },
                Characters = "\u2271"
            });
            Entities.Add("&ngeqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8807, 824 },
                Characters = "\u2267\u0338"
            });
            Entities.Add("&ngeqslant;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10878, 824 },
                Characters = "\u2A7E\u0338"
            });
            Entities.Add("&nges;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10878, 824 },
                Characters = "\u2A7E\u0338"
            });
            Entities.Add("&ngsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8821 },
                Characters = "\u2275"
            });
            Entities.Add("&ngt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8815 },
                Characters = "\u226F"
            });
            Entities.Add("&ngtr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8815 },
                Characters = "\u226F"
            });
            Entities.Add("&nhArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8654 },
                Characters = "\u21CE"
            });
            Entities.Add("&nharr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8622 },
                Characters = "\u21AE"
            });
            Entities.Add("&nhpar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10994 },
                Characters = "\u2AF2"
            });
            Entities.Add("&ni;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8715 },
                Characters = "\u220B"
            });
            Entities.Add("&nis;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8956 },
                Characters = "\u22FC"
            });
            Entities.Add("&nisd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8954 },
                Characters = "\u22FA"
            });
            Entities.Add("&niv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8715 },
                Characters = "\u220B"
            });
            Entities.Add("&njcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1114 },
                Characters = "\u045A"
            });
            Entities.Add("&nlArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8653 },
                Characters = "\u21CD"
            });
            Entities.Add("&nlE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8806, 824 },
                Characters = "\u2266\u0338"
            });
            Entities.Add("&nlarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8602 },
                Characters = "\u219A"
            });
            Entities.Add("&nldr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8229 },
                Characters = "\u2025"
            });
            Entities.Add("&nle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8816 },
                Characters = "\u2270"
            });
            Entities.Add("&nleftarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8602 },
                Characters = "\u219A"
            });
            Entities.Add("&nleftrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8622 },
                Characters = "\u21AE"
            });
            Entities.Add("&nleq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8816 },
                Characters = "\u2270"
            });
            Entities.Add("&nleqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8806, 824 },
                Characters = "\u2266\u0338"
            });
            Entities.Add("&nleqslant;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10877, 824 },
                Characters = "\u2A7D\u0338"
            });
            Entities.Add("&nles;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10877, 824 },
                Characters = "\u2A7D\u0338"
            });
            Entities.Add("&nless;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8814 },
                Characters = "\u226E"
            });
            Entities.Add("&nlsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8820 },
                Characters = "\u2274"
            });
            Entities.Add("&nlt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8814 },
                Characters = "\u226E"
            });
            Entities.Add("&nltri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8938 },
                Characters = "\u22EA"
            });
            Entities.Add("&nltrie;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8940 },
                Characters = "\u22EC"
            });
            Entities.Add("&nmid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8740 },
                Characters = "\u2224"
            });
            Entities.Add("&nopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120159 },
                Characters = "\uD835\uDD5F"
            });
            Entities.Add("&not", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 172 },
                Characters = "\u00AC"
            });
            Entities.Add("&not;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 172 },
                Characters = "\u00AC"
            });
            Entities.Add("&notin;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8713 },
                Characters = "\u2209"
            });
            Entities.Add("&notinE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8953, 824 },
                Characters = "\u22F9\u0338"
            });
            Entities.Add("&notindot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8949, 824 },
                Characters = "\u22F5\u0338"
            });
            Entities.Add("&notinva;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8713 },
                Characters = "\u2209"
            });
            Entities.Add("&notinvb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8951 },
                Characters = "\u22F7"
            });
            Entities.Add("&notinvc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8950 },
                Characters = "\u22F6"
            });
            Entities.Add("&notni;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8716 },
                Characters = "\u220C"
            });
            Entities.Add("&notniva;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8716 },
                Characters = "\u220C"
            });
            Entities.Add("&notnivb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8958 },
                Characters = "\u22FE"
            });
            Entities.Add("&notnivc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8957 },
                Characters = "\u22FD"
            });
            Entities.Add("&npar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8742 },
                Characters = "\u2226"
            });
            Entities.Add("&nparallel;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8742 },
                Characters = "\u2226"
            });
            Entities.Add("&nparsl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 11005, 8421 },
                Characters = "\u2AFD\u20E5"
            });
            Entities.Add("&npart;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8706, 824 },
                Characters = "\u2202\u0338"
            });
            Entities.Add("&npolint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10772 },
                Characters = "\u2A14"
            });
            Entities.Add("&npr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8832 },
                Characters = "\u2280"
            });
            Entities.Add("&nprcue;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8928 },
                Characters = "\u22E0"
            });
            Entities.Add("&npre;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10927, 824 },
                Characters = "\u2AAF\u0338"
            });
            Entities.Add("&nprec;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8832 },
                Characters = "\u2280"
            });
            Entities.Add("&npreceq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10927, 824 },
                Characters = "\u2AAF\u0338"
            });
            Entities.Add("&nrArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8655 },
                Characters = "\u21CF"
            });
            Entities.Add("&nrarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8603 },
                Characters = "\u219B"
            });
            Entities.Add("&nrarrc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10547, 824 },
                Characters = "\u2933\u0338"
            });
            Entities.Add("&nrarrw;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8605, 824 },
                Characters = "\u219D\u0338"
            });
            Entities.Add("&nrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8603 },
                Characters = "\u219B"
            });
            Entities.Add("&nrtri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8939 },
                Characters = "\u22EB"
            });
            Entities.Add("&nrtrie;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8941 },
                Characters = "\u22ED"
            });
            Entities.Add("&nsc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8833 },
                Characters = "\u2281"
            });
            Entities.Add("&nsccue;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8929 },
                Characters = "\u22E1"
            });
            Entities.Add("&nsce;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10928, 824 },
                Characters = "\u2AB0\u0338"
            });
            Entities.Add("&nscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120003 },
                Characters = "\uD835\uDCC3"
            });
            Entities.Add("&nshortmid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8740 },
                Characters = "\u2224"
            });
            Entities.Add("&nshortparallel;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8742 },
                Characters = "\u2226"
            });
            Entities.Add("&nsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8769 },
                Characters = "\u2241"
            });
            Entities.Add("&nsime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8772 },
                Characters = "\u2244"
            });
            Entities.Add("&nsimeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8772 },
                Characters = "\u2244"
            });
            Entities.Add("&nsmid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8740 },
                Characters = "\u2224"
            });
            Entities.Add("&nspar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8742 },
                Characters = "\u2226"
            });
            Entities.Add("&nsqsube;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8930 },
                Characters = "\u22E2"
            });
            Entities.Add("&nsqsupe;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8931 },
                Characters = "\u22E3"
            });
            Entities.Add("&nsub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8836 },
                Characters = "\u2284"
            });
            Entities.Add("&nsubE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10949, 824 },
                Characters = "\u2AC5\u0338"
            });
            Entities.Add("&nsube;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8840 },
                Characters = "\u2288"
            });
            Entities.Add("&nsubset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8834, 8402 },
                Characters = "\u2282\u20D2"
            });
            Entities.Add("&nsubseteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8840 },
                Characters = "\u2288"
            });
            Entities.Add("&nsubseteqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10949, 824 },
                Characters = "\u2AC5\u0338"
            });
            Entities.Add("&nsucc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8833 },
                Characters = "\u2281"
            });
            Entities.Add("&nsucceq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10928, 824 },
                Characters = "\u2AB0\u0338"
            });
            Entities.Add("&nsup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8837 },
                Characters = "\u2285"
            });
            Entities.Add("&nsupE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10950, 824 },
                Characters = "\u2AC6\u0338"
            });
            Entities.Add("&nsupe;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8841 },
                Characters = "\u2289"
            });
            Entities.Add("&nsupset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8835, 8402 },
                Characters = "\u2283\u20D2"
            });
            Entities.Add("&nsupseteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8841 },
                Characters = "\u2289"
            });
            Entities.Add("&nsupseteqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10950, 824 },
                Characters = "\u2AC6\u0338"
            });
            Entities.Add("&ntgl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8825 },
                Characters = "\u2279"
            });
            Entities.Add("&ntilde", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 241 },
                Characters = "\u00F1"
            });
            Entities.Add("&ntilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 241 },
                Characters = "\u00F1"
            });
            Entities.Add("&ntlg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8824 },
                Characters = "\u2278"
            });
            Entities.Add("&ntriangleleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8938 },
                Characters = "\u22EA"
            });
            Entities.Add("&ntrianglelefteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8940 },
                Characters = "\u22EC"
            });
            Entities.Add("&ntriangleright;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8939 },
                Characters = "\u22EB"
            });
            Entities.Add("&ntrianglerighteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8941 },
                Characters = "\u22ED"
            });
            Entities.Add("&nu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 957 },
                Characters = "\u03BD"
            });
            Entities.Add("&num;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 35 },
                Characters = "\u0023"
            });
            Entities.Add("&numero;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8470 },
                Characters = "\u2116"
            });
            Entities.Add("&numsp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8199 },
                Characters = "\u2007"
            });
            Entities.Add("&nvDash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8877 },
                Characters = "\u22AD"
            });
            Entities.Add("&nvHarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10500 },
                Characters = "\u2904"
            });
            Entities.Add("&nvap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8781, 8402 },
                Characters = "\u224D\u20D2"
            });
            Entities.Add("&nvdash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8876 },
                Characters = "\u22AC"
            });
            Entities.Add("&nvge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8805, 8402 },
                Characters = "\u2265\u20D2"
            });
            Entities.Add("&nvgt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 62, 8402 },
                Characters = "\u003E\u20D2"
            });
            Entities.Add("&nvinfin;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10718 },
                Characters = "\u29DE"
            });
            Entities.Add("&nvlArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10498 },
                Characters = "\u2902"
            });
            Entities.Add("&nvle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8804, 8402 },
                Characters = "\u2264\u20D2"
            });
            Entities.Add("&nvlt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 60, 8402 },
                Characters = "\u003C\u20D2"
            });
            Entities.Add("&nvltrie;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8884, 8402 },
                Characters = "\u22B4\u20D2"
            });
            Entities.Add("&nvrArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10499 },
                Characters = "\u2903"
            });
            Entities.Add("&nvrtrie;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8885, 8402 },
                Characters = "\u22B5\u20D2"
            });
            Entities.Add("&nvsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8764, 8402 },
                Characters = "\u223C\u20D2"
            });
            Entities.Add("&nwArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8662 },
                Characters = "\u21D6"
            });
            Entities.Add("&nwarhk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10531 },
                Characters = "\u2923"
            });
            Entities.Add("&nwarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8598 },
                Characters = "\u2196"
            });
            Entities.Add("&nwarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8598 },
                Characters = "\u2196"
            });
            Entities.Add("&nwnear;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10535 },
                Characters = "\u2927"
            });
            Entities.Add("&oS;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9416 },
                Characters = "\u24C8"
            });
            Entities.Add("&oacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 243 },
                Characters = "\u00F3"
            });
            Entities.Add("&oacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 243 },
                Characters = "\u00F3"
            });
            Entities.Add("&oast;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8859 },
                Characters = "\u229B"
            });
            Entities.Add("&ocir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8858 },
                Characters = "\u229A"
            });
            Entities.Add("&ocirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 244 },
                Characters = "\u00F4"
            });
            Entities.Add("&ocirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 244 },
                Characters = "\u00F4"
            });
            Entities.Add("&ocy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1086 },
                Characters = "\u043E"
            });
            Entities.Add("&odash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8861 },
                Characters = "\u229D"
            });
            Entities.Add("&odblac;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 337 },
                Characters = "\u0151"
            });
            Entities.Add("&odiv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10808 },
                Characters = "\u2A38"
            });
            Entities.Add("&odot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8857 },
                Characters = "\u2299"
            });
            Entities.Add("&odsold;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10684 },
                Characters = "\u29BC"
            });
            Entities.Add("&oelig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 339 },
                Characters = "\u0153"
            });
            Entities.Add("&ofcir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10687 },
                Characters = "\u29BF"
            });
            Entities.Add("&ofr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120108 },
                Characters = "\uD835\uDD2C"
            });
            Entities.Add("&ogon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 731 },
                Characters = "\u02DB"
            });
            Entities.Add("&ograve", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 242 },
                Characters = "\u00F2"
            });
            Entities.Add("&ograve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 242 },
                Characters = "\u00F2"
            });
            Entities.Add("&ogt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10689 },
                Characters = "\u29C1"
            });
            Entities.Add("&ohbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10677 },
                Characters = "\u29B5"
            });
            Entities.Add("&ohm;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 937 },
                Characters = "\u03A9"
            });
            Entities.Add("&oint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8750 },
                Characters = "\u222E"
            });
            Entities.Add("&olarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8634 },
                Characters = "\u21BA"
            });
            Entities.Add("&olcir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10686 },
                Characters = "\u29BE"
            });
            Entities.Add("&olcross;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10683 },
                Characters = "\u29BB"
            });
            Entities.Add("&oline;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8254 },
                Characters = "\u203E"
            });
            Entities.Add("&olt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10688 },
                Characters = "\u29C0"
            });
            Entities.Add("&omacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 333 },
                Characters = "\u014D"
            });
            Entities.Add("&omega;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 969 },
                Characters = "\u03C9"
            });
            Entities.Add("&omicron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 959 },
                Characters = "\u03BF"
            });
            Entities.Add("&omid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10678 },
                Characters = "\u29B6"
            });
            Entities.Add("&ominus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8854 },
                Characters = "\u2296"
            });
            Entities.Add("&oopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120160 },
                Characters = "\uD835\uDD60"
            });
            Entities.Add("&opar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10679 },
                Characters = "\u29B7"
            });
            Entities.Add("&operp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10681 },
                Characters = "\u29B9"
            });
            Entities.Add("&oplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8853 },
                Characters = "\u2295"
            });
            Entities.Add("&or;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8744 },
                Characters = "\u2228"
            });
            Entities.Add("&orarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8635 },
                Characters = "\u21BB"
            });
            Entities.Add("&ord;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10845 },
                Characters = "\u2A5D"
            });
            Entities.Add("&order;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8500 },
                Characters = "\u2134"
            });
            Entities.Add("&orderof;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8500 },
                Characters = "\u2134"
            });
            Entities.Add("&ordf", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 170 },
                Characters = "\u00AA"
            });
            Entities.Add("&ordf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 170 },
                Characters = "\u00AA"
            });
            Entities.Add("&ordm", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 186 },
                Characters = "\u00BA"
            });
            Entities.Add("&ordm;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 186 },
                Characters = "\u00BA"
            });
            Entities.Add("&origof;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8886 },
                Characters = "\u22B6"
            });
            Entities.Add("&oror;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10838 },
                Characters = "\u2A56"
            });
            Entities.Add("&orslope;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10839 },
                Characters = "\u2A57"
            });
            Entities.Add("&orv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10843 },
                Characters = "\u2A5B"
            });
            Entities.Add("&oscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8500 },
                Characters = "\u2134"
            });
            Entities.Add("&oslash", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 248 },
                Characters = "\u00F8"
            });
            Entities.Add("&oslash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 248 },
                Characters = "\u00F8"
            });
            Entities.Add("&osol;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8856 },
                Characters = "\u2298"
            });
            Entities.Add("&otilde", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 245 },
                Characters = "\u00F5"
            });
            Entities.Add("&otilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 245 },
                Characters = "\u00F5"
            });
            Entities.Add("&otimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8855 },
                Characters = "\u2297"
            });
            Entities.Add("&otimesas;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10806 },
                Characters = "\u2A36"
            });
            Entities.Add("&ouml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 246 },
                Characters = "\u00F6"
            });
            Entities.Add("&ouml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 246 },
                Characters = "\u00F6"
            });
            Entities.Add("&ovbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9021 },
                Characters = "\u233D"
            });
            Entities.Add("&par;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8741 },
                Characters = "\u2225"
            });
            Entities.Add("&para", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 182 },
                Characters = "\u00B6"
            });
            Entities.Add("&para;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 182 },
                Characters = "\u00B6"
            });
            Entities.Add("&parallel;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8741 },
                Characters = "\u2225"
            });
            Entities.Add("&parsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10995 },
                Characters = "\u2AF3"
            });
            Entities.Add("&parsl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 11005 },
                Characters = "\u2AFD"
            });
            Entities.Add("&part;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8706 },
                Characters = "\u2202"
            });
            Entities.Add("&pcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1087 },
                Characters = "\u043F"
            });
            Entities.Add("&percnt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 37 },
                Characters = "\u0025"
            });
            Entities.Add("&period;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 46 },
                Characters = "\u002E"
            });
            Entities.Add("&permil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8240 },
                Characters = "\u2030"
            });
            Entities.Add("&perp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8869 },
                Characters = "\u22A5"
            });
            Entities.Add("&pertenk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8241 },
                Characters = "\u2031"
            });
            Entities.Add("&pfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120109 },
                Characters = "\uD835\uDD2D"
            });
            Entities.Add("&phi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 966 },
                Characters = "\u03C6"
            });
            Entities.Add("&phiv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 981 },
                Characters = "\u03D5"
            });
            Entities.Add("&phmmat;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8499 },
                Characters = "\u2133"
            });
            Entities.Add("&phone;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9742 },
                Characters = "\u260E"
            });
            Entities.Add("&pi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 960 },
                Characters = "\u03C0"
            });
            Entities.Add("&pitchfork;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8916 },
                Characters = "\u22D4"
            });
            Entities.Add("&piv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 982 },
                Characters = "\u03D6"
            });
            Entities.Add("&planck;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8463 },
                Characters = "\u210F"
            });
            Entities.Add("&planckh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8462 },
                Characters = "\u210E"
            });
            Entities.Add("&plankv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8463 },
                Characters = "\u210F"
            });
            Entities.Add("&plus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 43 },
                Characters = "\u002B"
            });
            Entities.Add("&plusacir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10787 },
                Characters = "\u2A23"
            });
            Entities.Add("&plusb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8862 },
                Characters = "\u229E"
            });
            Entities.Add("&pluscir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10786 },
                Characters = "\u2A22"
            });
            Entities.Add("&plusdo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8724 },
                Characters = "\u2214"
            });
            Entities.Add("&plusdu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10789 },
                Characters = "\u2A25"
            });
            Entities.Add("&pluse;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10866 },
                Characters = "\u2A72"
            });
            Entities.Add("&plusmn", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 177 },
                Characters = "\u00B1"
            });
            Entities.Add("&plusmn;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 177 },
                Characters = "\u00B1"
            });
            Entities.Add("&plussim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10790 },
                Characters = "\u2A26"
            });
            Entities.Add("&plustwo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10791 },
                Characters = "\u2A27"
            });
            Entities.Add("&pm;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 177 },
                Characters = "\u00B1"
            });
            Entities.Add("&pointint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10773 },
                Characters = "\u2A15"
            });
            Entities.Add("&popf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120161 },
                Characters = "\uD835\uDD61"
            });
            Entities.Add("&pound", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 163 },
                Characters = "\u00A3"
            });
            Entities.Add("&pound;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 163 },
                Characters = "\u00A3"
            });
            Entities.Add("&pr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8826 },
                Characters = "\u227A"
            });
            Entities.Add("&prE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10931 },
                Characters = "\u2AB3"
            });
            Entities.Add("&prap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10935 },
                Characters = "\u2AB7"
            });
            Entities.Add("&prcue;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8828 },
                Characters = "\u227C"
            });
            Entities.Add("&pre;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10927 },
                Characters = "\u2AAF"
            });
            Entities.Add("&prec;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8826 },
                Characters = "\u227A"
            });
            Entities.Add("&precapprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10935 },
                Characters = "\u2AB7"
            });
            Entities.Add("&preccurlyeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8828 },
                Characters = "\u227C"
            });
            Entities.Add("&preceq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10927 },
                Characters = "\u2AAF"
            });
            Entities.Add("&precnapprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10937 },
                Characters = "\u2AB9"
            });
            Entities.Add("&precneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10933 },
                Characters = "\u2AB5"
            });
            Entities.Add("&precnsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8936 },
                Characters = "\u22E8"
            });
            Entities.Add("&precsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8830 },
                Characters = "\u227E"
            });
            Entities.Add("&prime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8242 },
                Characters = "\u2032"
            });
            Entities.Add("&primes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8473 },
                Characters = "\u2119"
            });
            Entities.Add("&prnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10933 },
                Characters = "\u2AB5"
            });
            Entities.Add("&prnap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10937 },
                Characters = "\u2AB9"
            });
            Entities.Add("&prnsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8936 },
                Characters = "\u22E8"
            });
            Entities.Add("&prod;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8719 },
                Characters = "\u220F"
            });
            Entities.Add("&profalar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9006 },
                Characters = "\u232E"
            });
            Entities.Add("&profline;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8978 },
                Characters = "\u2312"
            });
            Entities.Add("&profsurf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8979 },
                Characters = "\u2313"
            });
            Entities.Add("&prop;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8733 },
                Characters = "\u221D"
            });
            Entities.Add("&propto;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8733 },
                Characters = "\u221D"
            });
            Entities.Add("&prsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8830 },
                Characters = "\u227E"
            });
            Entities.Add("&prurel;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8880 },
                Characters = "\u22B0"
            });
            Entities.Add("&pscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120005 },
                Characters = "\uD835\uDCC5"
            });
            Entities.Add("&psi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 968 },
                Characters = "\u03C8"
            });
            Entities.Add("&puncsp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8200 },
                Characters = "\u2008"
            });
            Entities.Add("&qfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120110 },
                Characters = "\uD835\uDD2E"
            });
            Entities.Add("&qint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10764 },
                Characters = "\u2A0C"
            });
            Entities.Add("&qopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120162 },
                Characters = "\uD835\uDD62"
            });
            Entities.Add("&qprime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8279 },
                Characters = "\u2057"
            });
            Entities.Add("&qscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120006 },
                Characters = "\uD835\uDCC6"
            });
            Entities.Add("&quaternions;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8461 },
                Characters = "\u210D"
            });
            Entities.Add("&quatint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10774 },
                Characters = "\u2A16"
            });
            Entities.Add("&quest;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 63 },
                Characters = "\u003F"
            });
            Entities.Add("&questeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8799 },
                Characters = "\u225F"
            });
            Entities.Add("&quot", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 34 },
                Characters = "\u0022"
            });
            Entities.Add("&quot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 34 },
                Characters = "\u0022"
            });
            Entities.Add("&rAarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8667 },
                Characters = "\u21DB"
            });
            Entities.Add("&rArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8658 },
                Characters = "\u21D2"
            });
            Entities.Add("&rAtail;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10524 },
                Characters = "\u291C"
            });
            Entities.Add("&rBarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10511 },
                Characters = "\u290F"
            });
            Entities.Add("&rHar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10596 },
                Characters = "\u2964"
            });
            Entities.Add("&race;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8765, 817 },
                Characters = "\u223D\u0331"
            });
            Entities.Add("&racute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 341 },
                Characters = "\u0155"
            });
            Entities.Add("&radic;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8730 },
                Characters = "\u221A"
            });
            Entities.Add("&raemptyv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10675 },
                Characters = "\u29B3"
            });
            Entities.Add("&rang;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10217 },
                Characters = "\u27E9"
            });
            Entities.Add("&rangd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10642 },
                Characters = "\u2992"
            });
            Entities.Add("&range;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10661 },
                Characters = "\u29A5"
            });
            Entities.Add("&rangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10217 },
                Characters = "\u27E9"
            });
            Entities.Add("&raquo", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 187 },
                Characters = "\u00BB"
            });
            Entities.Add("&raquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 187 },
                Characters = "\u00BB"
            });
            Entities.Add("&rarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8594 },
                Characters = "\u2192"
            });
            Entities.Add("&rarrap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10613 },
                Characters = "\u2975"
            });
            Entities.Add("&rarrb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8677 },
                Characters = "\u21E5"
            });
            Entities.Add("&rarrbfs;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10528 },
                Characters = "\u2920"
            });
            Entities.Add("&rarrc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10547 },
                Characters = "\u2933"
            });
            Entities.Add("&rarrfs;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10526 },
                Characters = "\u291E"
            });
            Entities.Add("&rarrhk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8618 },
                Characters = "\u21AA"
            });
            Entities.Add("&rarrlp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8620 },
                Characters = "\u21AC"
            });
            Entities.Add("&rarrpl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10565 },
                Characters = "\u2945"
            });
            Entities.Add("&rarrsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10612 },
                Characters = "\u2974"
            });
            Entities.Add("&rarrtl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8611 },
                Characters = "\u21A3"
            });
            Entities.Add("&rarrw;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8605 },
                Characters = "\u219D"
            });
            Entities.Add("&ratail;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10522 },
                Characters = "\u291A"
            });
            Entities.Add("&ratio;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8758 },
                Characters = "\u2236"
            });
            Entities.Add("&rationals;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8474 },
                Characters = "\u211A"
            });
            Entities.Add("&rbarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10509 },
                Characters = "\u290D"
            });
            Entities.Add("&rbbrk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10099 },
                Characters = "\u2773"
            });
            Entities.Add("&rbrace;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 125 },
                Characters = "\u007D"
            });
            Entities.Add("&rbrack;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 93 },
                Characters = "\u005D"
            });
            Entities.Add("&rbrke;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10636 },
                Characters = "\u298C"
            });
            Entities.Add("&rbrksld;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10638 },
                Characters = "\u298E"
            });
            Entities.Add("&rbrkslu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10640 },
                Characters = "\u2990"
            });
            Entities.Add("&rcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 345 },
                Characters = "\u0159"
            });
            Entities.Add("&rcedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 343 },
                Characters = "\u0157"
            });
            Entities.Add("&rceil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8969 },
                Characters = "\u2309"
            });
            Entities.Add("&rcub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 125 },
                Characters = "\u007D"
            });
            Entities.Add("&rcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1088 },
                Characters = "\u0440"
            });
            Entities.Add("&rdca;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10551 },
                Characters = "\u2937"
            });
            Entities.Add("&rdldhar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10601 },
                Characters = "\u2969"
            });
            Entities.Add("&rdquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8221 },
                Characters = "\u201D"
            });
            Entities.Add("&rdquor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8221 },
                Characters = "\u201D"
            });
            Entities.Add("&rdsh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8627 },
                Characters = "\u21B3"
            });
            Entities.Add("&real;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8476 },
                Characters = "\u211C"
            });
            Entities.Add("&realine;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8475 },
                Characters = "\u211B"
            });
            Entities.Add("&realpart;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8476 },
                Characters = "\u211C"
            });
            Entities.Add("&reals;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8477 },
                Characters = "\u211D"
            });
            Entities.Add("&rect;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9645 },
                Characters = "\u25AD"
            });
            Entities.Add("&reg", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 174 },
                Characters = "\u00AE"
            });
            Entities.Add("&reg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 174 },
                Characters = "\u00AE"
            });
            Entities.Add("&rfisht;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10621 },
                Characters = "\u297D"
            });
            Entities.Add("&rfloor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8971 },
                Characters = "\u230B"
            });
            Entities.Add("&rfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120111 },
                Characters = "\uD835\uDD2F"
            });
            Entities.Add("&rhard;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8641 },
                Characters = "\u21C1"
            });
            Entities.Add("&rharu;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8640 },
                Characters = "\u21C0"
            });
            Entities.Add("&rharul;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10604 },
                Characters = "\u296C"
            });
            Entities.Add("&rho;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 961 },
                Characters = "\u03C1"
            });
            Entities.Add("&rhov;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1009 },
                Characters = "\u03F1"
            });
            Entities.Add("&rightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8594 },
                Characters = "\u2192"
            });
            Entities.Add("&rightarrowtail;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8611 },
                Characters = "\u21A3"
            });
            Entities.Add("&rightharpoondown;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8641 },
                Characters = "\u21C1"
            });
            Entities.Add("&rightharpoonup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8640 },
                Characters = "\u21C0"
            });
            Entities.Add("&rightleftarrows;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8644 },
                Characters = "\u21C4"
            });
            Entities.Add("&rightleftharpoons;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8652 },
                Characters = "\u21CC"
            });
            Entities.Add("&rightrightarrows;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8649 },
                Characters = "\u21C9"
            });
            Entities.Add("&rightsquigarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8605 },
                Characters = "\u219D"
            });
            Entities.Add("&rightthreetimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8908 },
                Characters = "\u22CC"
            });
            Entities.Add("&ring;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 730 },
                Characters = "\u02DA"
            });
            Entities.Add("&risingdotseq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8787 },
                Characters = "\u2253"
            });
            Entities.Add("&rlarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8644 },
                Characters = "\u21C4"
            });
            Entities.Add("&rlhar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8652 },
                Characters = "\u21CC"
            });
            Entities.Add("&rlm;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8207 },
                Characters = "\u200F"
            });
            Entities.Add("&rmoust;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9137 },
                Characters = "\u23B1"
            });
            Entities.Add("&rmoustache;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9137 },
                Characters = "\u23B1"
            });
            Entities.Add("&rnmid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10990 },
                Characters = "\u2AEE"
            });
            Entities.Add("&roang;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10221 },
                Characters = "\u27ED"
            });
            Entities.Add("&roarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8702 },
                Characters = "\u21FE"
            });
            Entities.Add("&robrk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10215 },
                Characters = "\u27E7"
            });
            Entities.Add("&ropar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10630 },
                Characters = "\u2986"
            });
            Entities.Add("&ropf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120163 },
                Characters = "\uD835\uDD63"
            });
            Entities.Add("&roplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10798 },
                Characters = "\u2A2E"
            });
            Entities.Add("&rotimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10805 },
                Characters = "\u2A35"
            });
            Entities.Add("&rpar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 41 },
                Characters = "\u0029"
            });
            Entities.Add("&rpargt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10644 },
                Characters = "\u2994"
            });
            Entities.Add("&rppolint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10770 },
                Characters = "\u2A12"
            });
            Entities.Add("&rrarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8649 },
                Characters = "\u21C9"
            });
            Entities.Add("&rsaquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8250 },
                Characters = "\u203A"
            });
            Entities.Add("&rscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120007 },
                Characters = "\uD835\uDCC7"
            });
            Entities.Add("&rsh;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8625 },
                Characters = "\u21B1"
            });
            Entities.Add("&rsqb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 93 },
                Characters = "\u005D"
            });
            Entities.Add("&rsquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8217 },
                Characters = "\u2019"
            });
            Entities.Add("&rsquor;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8217 },
                Characters = "\u2019"
            });
            Entities.Add("&rthree;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8908 },
                Characters = "\u22CC"
            });
            Entities.Add("&rtimes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8906 },
                Characters = "\u22CA"
            });
            Entities.Add("&rtri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9657 },
                Characters = "\u25B9"
            });
            Entities.Add("&rtrie;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8885 },
                Characters = "\u22B5"
            });
            Entities.Add("&rtrif;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9656 },
                Characters = "\u25B8"
            });
            Entities.Add("&rtriltri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10702 },
                Characters = "\u29CE"
            });
            Entities.Add("&ruluhar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10600 },
                Characters = "\u2968"
            });
            Entities.Add("&rx;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8478 },
                Characters = "\u211E"
            });
            Entities.Add("&sacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 347 },
                Characters = "\u015B"
            });
            Entities.Add("&sbquo;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8218 },
                Characters = "\u201A"
            });
            Entities.Add("&sc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8827 },
                Characters = "\u227B"
            });
            Entities.Add("&scE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10932 },
                Characters = "\u2AB4"
            });
            Entities.Add("&scap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10936 },
                Characters = "\u2AB8"
            });
            Entities.Add("&scaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 353 },
                Characters = "\u0161"
            });
            Entities.Add("&sccue;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8829 },
                Characters = "\u227D"
            });
            Entities.Add("&sce;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10928 },
                Characters = "\u2AB0"
            });
            Entities.Add("&scedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 351 },
                Characters = "\u015F"
            });
            Entities.Add("&scirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 349 },
                Characters = "\u015D"
            });
            Entities.Add("&scnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10934 },
                Characters = "\u2AB6"
            });
            Entities.Add("&scnap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10938 },
                Characters = "\u2ABA"
            });
            Entities.Add("&scnsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8937 },
                Characters = "\u22E9"
            });
            Entities.Add("&scpolint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10771 },
                Characters = "\u2A13"
            });
            Entities.Add("&scsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8831 },
                Characters = "\u227F"
            });
            Entities.Add("&scy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1089 },
                Characters = "\u0441"
            });
            Entities.Add("&sdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8901 },
                Characters = "\u22C5"
            });
            Entities.Add("&sdotb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8865 },
                Characters = "\u22A1"
            });
            Entities.Add("&sdote;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10854 },
                Characters = "\u2A66"
            });
            Entities.Add("&seArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8664 },
                Characters = "\u21D8"
            });
            Entities.Add("&searhk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10533 },
                Characters = "\u2925"
            });
            Entities.Add("&searr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8600 },
                Characters = "\u2198"
            });
            Entities.Add("&searrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8600 },
                Characters = "\u2198"
            });
            Entities.Add("&sect", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 167 },
                Characters = "\u00A7"
            });
            Entities.Add("&sect;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 167 },
                Characters = "\u00A7"
            });
            Entities.Add("&semi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 59 },
                Characters = "\u003B"
            });
            Entities.Add("&seswar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10537 },
                Characters = "\u2929"
            });
            Entities.Add("&setminus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8726 },
                Characters = "\u2216"
            });
            Entities.Add("&setmn;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8726 },
                Characters = "\u2216"
            });
            Entities.Add("&sext;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10038 },
                Characters = "\u2736"
            });
            Entities.Add("&sfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120112 },
                Characters = "\uD835\uDD30"
            });
            Entities.Add("&sfrown;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8994 },
                Characters = "\u2322"
            });
            Entities.Add("&sharp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9839 },
                Characters = "\u266F"
            });
            Entities.Add("&shchcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1097 },
                Characters = "\u0449"
            });
            Entities.Add("&shcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1096 },
                Characters = "\u0448"
            });
            Entities.Add("&shortmid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8739 },
                Characters = "\u2223"
            });
            Entities.Add("&shortparallel;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8741 },
                Characters = "\u2225"
            });
            Entities.Add("&shy", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 173 },
                Characters = "\u00AD"
            });
            Entities.Add("&shy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 173 },
                Characters = "\u00AD"
            });
            Entities.Add("&sigma;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 963 },
                Characters = "\u03C3"
            });
            Entities.Add("&sigmaf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 962 },
                Characters = "\u03C2"
            });
            Entities.Add("&sigmav;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 962 },
                Characters = "\u03C2"
            });
            Entities.Add("&sim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8764 },
                Characters = "\u223C"
            });
            Entities.Add("&simdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10858 },
                Characters = "\u2A6A"
            });
            Entities.Add("&sime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8771 },
                Characters = "\u2243"
            });
            Entities.Add("&simeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8771 },
                Characters = "\u2243"
            });
            Entities.Add("&simg;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10910 },
                Characters = "\u2A9E"
            });
            Entities.Add("&simgE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10912 },
                Characters = "\u2AA0"
            });
            Entities.Add("&siml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10909 },
                Characters = "\u2A9D"
            });
            Entities.Add("&simlE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10911 },
                Characters = "\u2A9F"
            });
            Entities.Add("&simne;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8774 },
                Characters = "\u2246"
            });
            Entities.Add("&simplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10788 },
                Characters = "\u2A24"
            });
            Entities.Add("&simrarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10610 },
                Characters = "\u2972"
            });
            Entities.Add("&slarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8592 },
                Characters = "\u2190"
            });
            Entities.Add("&smallsetminus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8726 },
                Characters = "\u2216"
            });
            Entities.Add("&smashp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10803 },
                Characters = "\u2A33"
            });
            Entities.Add("&smeparsl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10724 },
                Characters = "\u29E4"
            });
            Entities.Add("&smid;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8739 },
                Characters = "\u2223"
            });
            Entities.Add("&smile;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8995 },
                Characters = "\u2323"
            });
            Entities.Add("&smt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10922 },
                Characters = "\u2AAA"
            });
            Entities.Add("&smte;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10924 },
                Characters = "\u2AAC"
            });
            Entities.Add("&smtes;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10924, 65024 },
                Characters = "\u2AAC\uFE00"
            });
            Entities.Add("&softcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1100 },
                Characters = "\u044C"
            });
            Entities.Add("&sol;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 47 },
                Characters = "\u002F"
            });
            Entities.Add("&solb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10692 },
                Characters = "\u29C4"
            });
            Entities.Add("&solbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9023 },
                Characters = "\u233F"
            });
            Entities.Add("&sopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120164 },
                Characters = "\uD835\uDD64"
            });
            Entities.Add("&spades;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9824 },
                Characters = "\u2660"
            });
            Entities.Add("&spadesuit;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9824 },
                Characters = "\u2660"
            });
            Entities.Add("&spar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8741 },
                Characters = "\u2225"
            });
            Entities.Add("&sqcap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8851 },
                Characters = "\u2293"
            });
            Entities.Add("&sqcaps;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8851, 65024 },
                Characters = "\u2293\uFE00"
            });
            Entities.Add("&sqcup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8852 },
                Characters = "\u2294"
            });
            Entities.Add("&sqcups;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8852, 65024 },
                Characters = "\u2294\uFE00"
            });
            Entities.Add("&sqsub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8847 },
                Characters = "\u228F"
            });
            Entities.Add("&sqsube;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8849 },
                Characters = "\u2291"
            });
            Entities.Add("&sqsubset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8847 },
                Characters = "\u228F"
            });
            Entities.Add("&sqsubseteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8849 },
                Characters = "\u2291"
            });
            Entities.Add("&sqsup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8848 },
                Characters = "\u2290"
            });
            Entities.Add("&sqsupe;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8850 },
                Characters = "\u2292"
            });
            Entities.Add("&sqsupset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8848 },
                Characters = "\u2290"
            });
            Entities.Add("&sqsupseteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8850 },
                Characters = "\u2292"
            });
            Entities.Add("&squ;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9633 },
                Characters = "\u25A1"
            });
            Entities.Add("&square;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9633 },
                Characters = "\u25A1"
            });
            Entities.Add("&squarf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9642 },
                Characters = "\u25AA"
            });
            Entities.Add("&squf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9642 },
                Characters = "\u25AA"
            });
            Entities.Add("&srarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8594 },
                Characters = "\u2192"
            });
            Entities.Add("&sscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120008 },
                Characters = "\uD835\uDCC8"
            });
            Entities.Add("&ssetmn;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8726 },
                Characters = "\u2216"
            });
            Entities.Add("&ssmile;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8995 },
                Characters = "\u2323"
            });
            Entities.Add("&sstarf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8902 },
                Characters = "\u22C6"
            });
            Entities.Add("&star;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9734 },
                Characters = "\u2606"
            });
            Entities.Add("&starf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9733 },
                Characters = "\u2605"
            });
            Entities.Add("&straightepsilon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1013 },
                Characters = "\u03F5"
            });
            Entities.Add("&straightphi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 981 },
                Characters = "\u03D5"
            });
            Entities.Add("&strns;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 175 },
                Characters = "\u00AF"
            });
            Entities.Add("&sub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8834 },
                Characters = "\u2282"
            });
            Entities.Add("&subE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10949 },
                Characters = "\u2AC5"
            });
            Entities.Add("&subdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10941 },
                Characters = "\u2ABD"
            });
            Entities.Add("&sube;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8838 },
                Characters = "\u2286"
            });
            Entities.Add("&subedot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10947 },
                Characters = "\u2AC3"
            });
            Entities.Add("&submult;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10945 },
                Characters = "\u2AC1"
            });
            Entities.Add("&subnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10955 },
                Characters = "\u2ACB"
            });
            Entities.Add("&subne;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8842 },
                Characters = "\u228A"
            });
            Entities.Add("&subplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10943 },
                Characters = "\u2ABF"
            });
            Entities.Add("&subrarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10617 },
                Characters = "\u2979"
            });
            Entities.Add("&subset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8834 },
                Characters = "\u2282"
            });
            Entities.Add("&subseteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8838 },
                Characters = "\u2286"
            });
            Entities.Add("&subseteqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10949 },
                Characters = "\u2AC5"
            });
            Entities.Add("&subsetneq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8842 },
                Characters = "\u228A"
            });
            Entities.Add("&subsetneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10955 },
                Characters = "\u2ACB"
            });
            Entities.Add("&subsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10951 },
                Characters = "\u2AC7"
            });
            Entities.Add("&subsub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10965 },
                Characters = "\u2AD5"
            });
            Entities.Add("&subsup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10963 },
                Characters = "\u2AD3"
            });
            Entities.Add("&succ;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8827 },
                Characters = "\u227B"
            });
            Entities.Add("&succapprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10936 },
                Characters = "\u2AB8"
            });
            Entities.Add("&succcurlyeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8829 },
                Characters = "\u227D"
            });
            Entities.Add("&succeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10928 },
                Characters = "\u2AB0"
            });
            Entities.Add("&succnapprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10938 },
                Characters = "\u2ABA"
            });
            Entities.Add("&succneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10934 },
                Characters = "\u2AB6"
            });
            Entities.Add("&succnsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8937 },
                Characters = "\u22E9"
            });
            Entities.Add("&succsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8831 },
                Characters = "\u227F"
            });
            Entities.Add("&sum;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8721 },
                Characters = "\u2211"
            });
            Entities.Add("&sung;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9834 },
                Characters = "\u266A"
            });
            Entities.Add("&sup1", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 185 },
                Characters = "\u00B9"
            });
            Entities.Add("&sup1;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 185 },
                Characters = "\u00B9"
            });
            Entities.Add("&sup2", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 178 },
                Characters = "\u00B2"
            });
            Entities.Add("&sup2;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 178 },
                Characters = "\u00B2"
            });
            Entities.Add("&sup3", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 179 },
                Characters = "\u00B3"
            });
            Entities.Add("&sup3;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 179 },
                Characters = "\u00B3"
            });
            Entities.Add("&sup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8835 },
                Characters = "\u2283"
            });
            Entities.Add("&supE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10950 },
                Characters = "\u2AC6"
            });
            Entities.Add("&supdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10942 },
                Characters = "\u2ABE"
            });
            Entities.Add("&supdsub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10968 },
                Characters = "\u2AD8"
            });
            Entities.Add("&supe;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8839 },
                Characters = "\u2287"
            });
            Entities.Add("&supedot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10948 },
                Characters = "\u2AC4"
            });
            Entities.Add("&suphsol;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10185 },
                Characters = "\u27C9"
            });
            Entities.Add("&suphsub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10967 },
                Characters = "\u2AD7"
            });
            Entities.Add("&suplarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10619 },
                Characters = "\u297B"
            });
            Entities.Add("&supmult;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10946 },
                Characters = "\u2AC2"
            });
            Entities.Add("&supnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10956 },
                Characters = "\u2ACC"
            });
            Entities.Add("&supne;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8843 },
                Characters = "\u228B"
            });
            Entities.Add("&supplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10944 },
                Characters = "\u2AC0"
            });
            Entities.Add("&supset;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8835 },
                Characters = "\u2283"
            });
            Entities.Add("&supseteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8839 },
                Characters = "\u2287"
            });
            Entities.Add("&supseteqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10950 },
                Characters = "\u2AC6"
            });
            Entities.Add("&supsetneq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8843 },
                Characters = "\u228B"
            });
            Entities.Add("&supsetneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10956 },
                Characters = "\u2ACC"
            });
            Entities.Add("&supsim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10952 },
                Characters = "\u2AC8"
            });
            Entities.Add("&supsub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10964 },
                Characters = "\u2AD4"
            });
            Entities.Add("&supsup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10966 },
                Characters = "\u2AD6"
            });
            Entities.Add("&swArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8665 },
                Characters = "\u21D9"
            });
            Entities.Add("&swarhk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10534 },
                Characters = "\u2926"
            });
            Entities.Add("&swarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8601 },
                Characters = "\u2199"
            });
            Entities.Add("&swarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8601 },
                Characters = "\u2199"
            });
            Entities.Add("&swnwar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10538 },
                Characters = "\u292A"
            });
            Entities.Add("&szlig", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 223 },
                Characters = "\u00DF"
            });
            Entities.Add("&szlig;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 223 },
                Characters = "\u00DF"
            });
            Entities.Add("&target;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8982 },
                Characters = "\u2316"
            });
            Entities.Add("&tau;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 964 },
                Characters = "\u03C4"
            });
            Entities.Add("&tbrk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9140 },
                Characters = "\u23B4"
            });
            Entities.Add("&tcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 357 },
                Characters = "\u0165"
            });
            Entities.Add("&tcedil;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 355 },
                Characters = "\u0163"
            });
            Entities.Add("&tcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1090 },
                Characters = "\u0442"
            });
            Entities.Add("&tdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8411 },
                Characters = "\u20DB"
            });
            Entities.Add("&telrec;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8981 },
                Characters = "\u2315"
            });
            Entities.Add("&tfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120113 },
                Characters = "\uD835\uDD31"
            });
            Entities.Add("&there4;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8756 },
                Characters = "\u2234"
            });
            Entities.Add("&therefore;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8756 },
                Characters = "\u2234"
            });
            Entities.Add("&theta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 952 },
                Characters = "\u03B8"
            });
            Entities.Add("&thetasym;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 977 },
                Characters = "\u03D1"
            });
            Entities.Add("&thetav;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 977 },
                Characters = "\u03D1"
            });
            Entities.Add("&thickapprox;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8776 },
                Characters = "\u2248"
            });
            Entities.Add("&thicksim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8764 },
                Characters = "\u223C"
            });
            Entities.Add("&thinsp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8201 },
                Characters = "\u2009"
            });
            Entities.Add("&thkap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8776 },
                Characters = "\u2248"
            });
            Entities.Add("&thksim;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8764 },
                Characters = "\u223C"
            });
            Entities.Add("&thorn", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 254 },
                Characters = "\u00FE"
            });
            Entities.Add("&thorn;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 254 },
                Characters = "\u00FE"
            });
            Entities.Add("&tilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 732 },
                Characters = "\u02DC"
            });
            Entities.Add("&times", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 215 },
                Characters = "\u00D7"
            });
            Entities.Add("&times;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 215 },
                Characters = "\u00D7"
            });
            Entities.Add("&timesb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8864 },
                Characters = "\u22A0"
            });
            Entities.Add("&timesbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10801 },
                Characters = "\u2A31"
            });
            Entities.Add("&timesd;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10800 },
                Characters = "\u2A30"
            });
            Entities.Add("&tint;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8749 },
                Characters = "\u222D"
            });
            Entities.Add("&toea;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10536 },
                Characters = "\u2928"
            });
            Entities.Add("&top;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8868 },
                Characters = "\u22A4"
            });
            Entities.Add("&topbot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9014 },
                Characters = "\u2336"
            });
            Entities.Add("&topcir;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10993 },
                Characters = "\u2AF1"
            });
            Entities.Add("&topf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120165 },
                Characters = "\uD835\uDD65"
            });
            Entities.Add("&topfork;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10970 },
                Characters = "\u2ADA"
            });
            Entities.Add("&tosa;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10537 },
                Characters = "\u2929"
            });
            Entities.Add("&tprime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8244 },
                Characters = "\u2034"
            });
            Entities.Add("&trade;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8482 },
                Characters = "\u2122"
            });
            Entities.Add("&triangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9653 },
                Characters = "\u25B5"
            });
            Entities.Add("&triangledown;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9663 },
                Characters = "\u25BF"
            });
            Entities.Add("&triangleleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9667 },
                Characters = "\u25C3"
            });
            Entities.Add("&trianglelefteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8884 },
                Characters = "\u22B4"
            });
            Entities.Add("&triangleq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8796 },
                Characters = "\u225C"
            });
            Entities.Add("&triangleright;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9657 },
                Characters = "\u25B9"
            });
            Entities.Add("&trianglerighteq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8885 },
                Characters = "\u22B5"
            });
            Entities.Add("&tridot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9708 },
                Characters = "\u25EC"
            });
            Entities.Add("&trie;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8796 },
                Characters = "\u225C"
            });
            Entities.Add("&triminus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10810 },
                Characters = "\u2A3A"
            });
            Entities.Add("&triplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10809 },
                Characters = "\u2A39"
            });
            Entities.Add("&trisb;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10701 },
                Characters = "\u29CD"
            });
            Entities.Add("&tritime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10811 },
                Characters = "\u2A3B"
            });
            Entities.Add("&trpezium;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9186 },
                Characters = "\u23E2"
            });
            Entities.Add("&tscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120009 },
                Characters = "\uD835\uDCC9"
            });
            Entities.Add("&tscy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1094 },
                Characters = "\u0446"
            });
            Entities.Add("&tshcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1115 },
                Characters = "\u045B"
            });
            Entities.Add("&tstrok;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 359 },
                Characters = "\u0167"
            });
            Entities.Add("&twixt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8812 },
                Characters = "\u226C"
            });
            Entities.Add("&twoheadleftarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8606 },
                Characters = "\u219E"
            });
            Entities.Add("&twoheadrightarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8608 },
                Characters = "\u21A0"
            });
            Entities.Add("&uArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8657 },
                Characters = "\u21D1"
            });
            Entities.Add("&uHar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10595 },
                Characters = "\u2963"
            });
            Entities.Add("&uacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 250 },
                Characters = "\u00FA"
            });
            Entities.Add("&uacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 250 },
                Characters = "\u00FA"
            });
            Entities.Add("&uarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8593 },
                Characters = "\u2191"
            });
            Entities.Add("&ubrcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1118 },
                Characters = "\u045E"
            });
            Entities.Add("&ubreve;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 365 },
                Characters = "\u016D"
            });
            Entities.Add("&ucirc", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 251 },
                Characters = "\u00FB"
            });
            Entities.Add("&ucirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 251 },
                Characters = "\u00FB"
            });
            Entities.Add("&ucy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1091 },
                Characters = "\u0443"
            });
            Entities.Add("&udarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8645 },
                Characters = "\u21C5"
            });
            Entities.Add("&udblac;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 369 },
                Characters = "\u0171"
            });
            Entities.Add("&udhar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10606 },
                Characters = "\u296E"
            });
            Entities.Add("&ufisht;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10622 },
                Characters = "\u297E"
            });
            Entities.Add("&ufr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120114 },
                Characters = "\uD835\uDD32"
            });
            Entities.Add("&ugrave", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 249 },
                Characters = "\u00F9"
            });
            Entities.Add("&ugrave;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 249 },
                Characters = "\u00F9"
            });
            Entities.Add("&uharl;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8639 },
                Characters = "\u21BF"
            });
            Entities.Add("&uharr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8638 },
                Characters = "\u21BE"
            });
            Entities.Add("&uhblk;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9600 },
                Characters = "\u2580"
            });
            Entities.Add("&ulcorn;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8988 },
                Characters = "\u231C"
            });
            Entities.Add("&ulcorner;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8988 },
                Characters = "\u231C"
            });
            Entities.Add("&ulcrop;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8975 },
                Characters = "\u230F"
            });
            Entities.Add("&ultri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9720 },
                Characters = "\u25F8"
            });
            Entities.Add("&umacr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 363 },
                Characters = "\u016B"
            });
            Entities.Add("&uml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 168 },
                Characters = "\u00A8"
            });
            Entities.Add("&uml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 168 },
                Characters = "\u00A8"
            });
            Entities.Add("&uogon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 371 },
                Characters = "\u0173"
            });
            Entities.Add("&uopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120166 },
                Characters = "\uD835\uDD66"
            });
            Entities.Add("&uparrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8593 },
                Characters = "\u2191"
            });
            Entities.Add("&updownarrow;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8597 },
                Characters = "\u2195"
            });
            Entities.Add("&upharpoonleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8639 },
                Characters = "\u21BF"
            });
            Entities.Add("&upharpoonright;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8638 },
                Characters = "\u21BE"
            });
            Entities.Add("&uplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8846 },
                Characters = "\u228E"
            });
            Entities.Add("&upsi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 965 },
                Characters = "\u03C5"
            });
            Entities.Add("&upsih;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 978 },
                Characters = "\u03D2"
            });
            Entities.Add("&upsilon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 965 },
                Characters = "\u03C5"
            });
            Entities.Add("&upuparrows;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8648 },
                Characters = "\u21C8"
            });
            Entities.Add("&urcorn;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8989 },
                Characters = "\u231D"
            });
            Entities.Add("&urcorner;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8989 },
                Characters = "\u231D"
            });
            Entities.Add("&urcrop;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8974 },
                Characters = "\u230E"
            });
            Entities.Add("&uring;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 367 },
                Characters = "\u016F"
            });
            Entities.Add("&urtri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9721 },
                Characters = "\u25F9"
            });
            Entities.Add("&uscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120010 },
                Characters = "\uD835\uDCCA"
            });
            Entities.Add("&utdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8944 },
                Characters = "\u22F0"
            });
            Entities.Add("&utilde;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 361 },
                Characters = "\u0169"
            });
            Entities.Add("&utri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9653 },
                Characters = "\u25B5"
            });
            Entities.Add("&utrif;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9652 },
                Characters = "\u25B4"
            });
            Entities.Add("&uuarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8648 },
                Characters = "\u21C8"
            });
            Entities.Add("&uuml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 252 },
                Characters = "\u00FC"
            });
            Entities.Add("&uuml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 252 },
                Characters = "\u00FC"
            });
            Entities.Add("&uwangle;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10663 },
                Characters = "\u29A7"
            });
            Entities.Add("&vArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8661 },
                Characters = "\u21D5"
            });
            Entities.Add("&vBar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10984 },
                Characters = "\u2AE8"
            });
            Entities.Add("&vBarv;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10985 },
                Characters = "\u2AE9"
            });
            Entities.Add("&vDash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8872 },
                Characters = "\u22A8"
            });
            Entities.Add("&vangrt;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10652 },
                Characters = "\u299C"
            });
            Entities.Add("&varepsilon;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1013 },
                Characters = "\u03F5"
            });
            Entities.Add("&varkappa;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1008 },
                Characters = "\u03F0"
            });
            Entities.Add("&varnothing;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8709 },
                Characters = "\u2205"
            });
            Entities.Add("&varphi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 981 },
                Characters = "\u03D5"
            });
            Entities.Add("&varpi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 982 },
                Characters = "\u03D6"
            });
            Entities.Add("&varpropto;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8733 },
                Characters = "\u221D"
            });
            Entities.Add("&varr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8597 },
                Characters = "\u2195"
            });
            Entities.Add("&varrho;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1009 },
                Characters = "\u03F1"
            });
            Entities.Add("&varsigma;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 962 },
                Characters = "\u03C2"
            });
            Entities.Add("&varsubsetneq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8842, 65024 },
                Characters = "\u228A\uFE00"
            });
            Entities.Add("&varsubsetneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10955, 65024 },
                Characters = "\u2ACB\uFE00"
            });
            Entities.Add("&varsupsetneq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8843, 65024 },
                Characters = "\u228B\uFE00"
            });
            Entities.Add("&varsupsetneqq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10956, 65024 },
                Characters = "\u2ACC\uFE00"
            });
            Entities.Add("&vartheta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 977 },
                Characters = "\u03D1"
            });
            Entities.Add("&vartriangleleft;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8882 },
                Characters = "\u22B2"
            });
            Entities.Add("&vartriangleright;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8883 },
                Characters = "\u22B3"
            });
            Entities.Add("&vcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1074 },
                Characters = "\u0432"
            });
            Entities.Add("&vdash;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8866 },
                Characters = "\u22A2"
            });
            Entities.Add("&vee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8744 },
                Characters = "\u2228"
            });
            Entities.Add("&veebar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8891 },
                Characters = "\u22BB"
            });
            Entities.Add("&veeeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8794 },
                Characters = "\u225A"
            });
            Entities.Add("&vellip;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8942 },
                Characters = "\u22EE"
            });
            Entities.Add("&verbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 124 },
                Characters = "\u007C"
            });
            Entities.Add("&vert;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 124 },
                Characters = "\u007C"
            });
            Entities.Add("&vfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120115 },
                Characters = "\uD835\uDD33"
            });
            Entities.Add("&vltri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8882 },
                Characters = "\u22B2"
            });
            Entities.Add("&vnsub;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8834, 8402 },
                Characters = "\u2282\u20D2"
            });
            Entities.Add("&vnsup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8835, 8402 },
                Characters = "\u2283\u20D2"
            });
            Entities.Add("&vopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120167 },
                Characters = "\uD835\uDD67"
            });
            Entities.Add("&vprop;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8733 },
                Characters = "\u221D"
            });
            Entities.Add("&vrtri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8883 },
                Characters = "\u22B3"
            });
            Entities.Add("&vscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120011 },
                Characters = "\uD835\uDCCB"
            });
            Entities.Add("&vsubnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10955, 65024 },
                Characters = "\u2ACB\uFE00"
            });
            Entities.Add("&vsubne;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8842, 65024 },
                Characters = "\u228A\uFE00"
            });
            Entities.Add("&vsupnE;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10956, 65024 },
                Characters = "\u2ACC\uFE00"
            });
            Entities.Add("&vsupne;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8843, 65024 },
                Characters = "\u228B\uFE00"
            });
            Entities.Add("&vzigzag;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10650 },
                Characters = "\u299A"
            });
            Entities.Add("&wcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 373 },
                Characters = "\u0175"
            });
            Entities.Add("&wedbar;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10847 },
                Characters = "\u2A5F"
            });
            Entities.Add("&wedge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8743 },
                Characters = "\u2227"
            });
            Entities.Add("&wedgeq;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8793 },
                Characters = "\u2259"
            });
            Entities.Add("&weierp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8472 },
                Characters = "\u2118"
            });
            Entities.Add("&wfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120116 },
                Characters = "\uD835\uDD34"
            });
            Entities.Add("&wopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120168 },
                Characters = "\uD835\uDD68"
            });
            Entities.Add("&wp;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8472 },
                Characters = "\u2118"
            });
            Entities.Add("&wr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8768 },
                Characters = "\u2240"
            });
            Entities.Add("&wreath;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8768 },
                Characters = "\u2240"
            });
            Entities.Add("&wscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120012 },
                Characters = "\uD835\uDCCC"
            });
            Entities.Add("&xcap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8898 },
                Characters = "\u22C2"
            });
            Entities.Add("&xcirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9711 },
                Characters = "\u25EF"
            });
            Entities.Add("&xcup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8899 },
                Characters = "\u22C3"
            });
            Entities.Add("&xdtri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9661 },
                Characters = "\u25BD"
            });
            Entities.Add("&xfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120117 },
                Characters = "\uD835\uDD35"
            });
            Entities.Add("&xhArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10234 },
                Characters = "\u27FA"
            });
            Entities.Add("&xharr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10231 },
                Characters = "\u27F7"
            });
            Entities.Add("&xi;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 958 },
                Characters = "\u03BE"
            });
            Entities.Add("&xlArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10232 },
                Characters = "\u27F8"
            });
            Entities.Add("&xlarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10229 },
                Characters = "\u27F5"
            });
            Entities.Add("&xmap;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10236 },
                Characters = "\u27FC"
            });
            Entities.Add("&xnis;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8955 },
                Characters = "\u22FB"
            });
            Entities.Add("&xodot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10752 },
                Characters = "\u2A00"
            });
            Entities.Add("&xopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120169 },
                Characters = "\uD835\uDD69"
            });
            Entities.Add("&xoplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10753 },
                Characters = "\u2A01"
            });
            Entities.Add("&xotime;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10754 },
                Characters = "\u2A02"
            });
            Entities.Add("&xrArr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10233 },
                Characters = "\u27F9"
            });
            Entities.Add("&xrarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10230 },
                Characters = "\u27F6"
            });
            Entities.Add("&xscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120013 },
                Characters = "\uD835\uDCCD"
            });
            Entities.Add("&xsqcup;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10758 },
                Characters = "\u2A06"
            });
            Entities.Add("&xuplus;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 10756 },
                Characters = "\u2A04"
            });
            Entities.Add("&xutri;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 9651 },
                Characters = "\u25B3"
            });
            Entities.Add("&xvee;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8897 },
                Characters = "\u22C1"
            });
            Entities.Add("&xwedge;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8896 },
                Characters = "\u22C0"
            });
            Entities.Add("&yacute", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 253 },
                Characters = "\u00FD"
            });
            Entities.Add("&yacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 253 },
                Characters = "\u00FD"
            });
            Entities.Add("&yacy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1103 },
                Characters = "\u044F"
            });
            Entities.Add("&ycirc;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 375 },
                Characters = "\u0177"
            });
            Entities.Add("&ycy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1099 },
                Characters = "\u044B"
            });
            Entities.Add("&yen", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 165 },
                Characters = "\u00A5"
            });
            Entities.Add("&yen;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 165 },
                Characters = "\u00A5"
            });
            Entities.Add("&yfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120118 },
                Characters = "\uD835\uDD36"
            });
            Entities.Add("&yicy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1111 },
                Characters = "\u0457"
            });
            Entities.Add("&yopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120170 },
                Characters = "\uD835\uDD6A"
            });
            Entities.Add("&yscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120014 },
                Characters = "\uD835\uDCCE"
            });
            Entities.Add("&yucy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1102 },
                Characters = "\u044E"
            });
            Entities.Add("&yuml", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 255 },
                Characters = "\u00FF"
            });
            Entities.Add("&yuml;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 255 },
                Characters = "\u00FF"
            });
            Entities.Add("&zacute;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 378 },
                Characters = "\u017A"
            });
            Entities.Add("&zcaron;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 382 },
                Characters = "\u017E"
            });
            Entities.Add("&zcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1079 },
                Characters = "\u0437"
            });
            Entities.Add("&zdot;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 380 },
                Characters = "\u017C"
            });
            Entities.Add("&zeetrf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8488 },
                Characters = "\u2128"
            });
            Entities.Add("&zeta;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 950 },
                Characters = "\u03B6"
            });
            Entities.Add("&zfr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120119 },
                Characters = "\uD835\uDD37"
            });
            Entities.Add("&zhcy;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 1078 },
                Characters = "\u0436"
            });
            Entities.Add("&zigrarr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8669 },
                Characters = "\u21DD"
            });
            Entities.Add("&zopf;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120171 },
                Characters = "\uD835\uDD6B"
            });
            Entities.Add("&zscr;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 120015 },
                Characters = "\uD835\uDCCF"
            });
            Entities.Add("&zwj;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8205 },
                Characters = "\u200D"
            });
            Entities.Add("&zwnj;", new Models.NamedCharacterReferenceCodepointModel
            {
                Codepoints = new[] { 8204 },
                Characters = "\u200C"
            });
            MaxKeyLength = Entities.Keys.Max(x => x.Length);
        }

        public string HasMatchingKeys(string value)
        {
            return Entities.Keys.FirstOrDefault(x => x.StartsWith(value));
        }
    }
}
