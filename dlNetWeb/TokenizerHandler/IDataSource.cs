using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public interface IDataSource
    {
        public int ReadPosition { get; set; }
        public ReadOnlyMemory<char> NextChar(int position, int length = 1);
    }
}
