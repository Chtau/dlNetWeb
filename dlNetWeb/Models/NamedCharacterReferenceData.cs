using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Models
{
    public class NamedCharacterReferenceData
    {
        public string Name { get; set; }
    }

    public class NamedCharacterReferenceCodepointData
    {
        public string Characters { get; set; }
        public int[] Codepoints { get; set; }
    }
}
