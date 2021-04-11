using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Helper
{
    public interface ILogger
    {
        void Error(Exception ex);
        void Error(string message);
        void Warning(Exception ex);
        void Warning(string message);
        void Info(Exception ex);
        void Info(string message);
        void Trace(Exception ex);
        void Trace(string message);
    }
}
