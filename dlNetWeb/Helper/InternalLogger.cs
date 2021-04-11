using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Helper
{
    internal class InternalLogger : ILogger
    {
        public void Error(Exception ex)
        {
            System.Diagnostics.Trace.TraceError(ex.ToString());
        }

        public void Error(string message)
        {
            System.Diagnostics.Trace.TraceError(message);
        }

        public void Info(Exception ex)
        {
            System.Diagnostics.Trace.TraceInformation(ex.ToString());
        }

        public void Info(string message)
        {
            System.Diagnostics.Trace.TraceInformation(message);
        }

        public void Trace(Exception ex)
        {
            System.Diagnostics.Trace.TraceInformation(ex.ToString());
        }

        public void Trace(string message)
        {
            System.Diagnostics.Trace.TraceInformation(message);
        }

        public void Warning(Exception ex)
        {
            System.Diagnostics.Trace.TraceWarning(ex.ToString());
        }

        public void Warning(string message)
        {
            System.Diagnostics.Trace.TraceWarning(message);
        }
    }
}
