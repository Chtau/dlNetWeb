using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class DataSourceMemory : IDataSource
    {
        private readonly ReadOnlyMemory<char> _memory;

        public DataSourceMemory(string content)
        {
            _memory = content?.AsMemory() ?? ReadOnlyMemory<char>.Empty;
        }

        public int ReadPosition { get; set; }

        public ReadOnlyMemory<char> NextChar(int position, int length = 1)
        {
            if (!_memory.IsEmpty && _memory.Length > (position + length))
                return _memory.Slice(position, length);
            return ReadOnlyMemory<char>.Empty;
        }
    }
}
