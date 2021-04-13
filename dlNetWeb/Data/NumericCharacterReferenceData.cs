using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Data
{
    public class NumericCharacterReferenceData
    {
        public Dictionary<Int32, Int32> NumberCodepoint { get; set; } = new Dictionary<int, int>();

        public NumericCharacterReferenceData()
        {
            NumberCodepoint.Add(0x80, 0x20AC);
            NumberCodepoint.Add(0x82, 0x201A);
            NumberCodepoint.Add(0x83, 0x0192);
            NumberCodepoint.Add(0x84, 0x201E);
            NumberCodepoint.Add(0x85, 0x2026);
            NumberCodepoint.Add(0x86, 0x2020);
            NumberCodepoint.Add(0x87, 0x2021);
            NumberCodepoint.Add(0x88, 0x02C6);
            NumberCodepoint.Add(0x89, 0x2030);
            NumberCodepoint.Add(0x8A, 0x0160);
            NumberCodepoint.Add(0x8B, 0x2039);
            NumberCodepoint.Add(0x8C, 0x0152);
            NumberCodepoint.Add(0x8E, 0x017D);
            NumberCodepoint.Add(0x91, 0x2018);
            NumberCodepoint.Add(0x92, 0x2019);
            NumberCodepoint.Add(0x93, 0x201C);
            NumberCodepoint.Add(0x94, 0x201D);
            NumberCodepoint.Add(0x95, 0x2022);
            NumberCodepoint.Add(0x96, 0x2013);
            NumberCodepoint.Add(0x97, 0x2014);
            NumberCodepoint.Add(0x98, 0x02DC);
            NumberCodepoint.Add(0x99, 0x2122);
            NumberCodepoint.Add(0x9A, 0x0161);
            NumberCodepoint.Add(0x9B, 0x203A);
            NumberCodepoint.Add(0x9C, 0x0153);
            NumberCodepoint.Add(0x9E, 0x017E);
            NumberCodepoint.Add(0x9F, 0x0178);
        }
    }
}
