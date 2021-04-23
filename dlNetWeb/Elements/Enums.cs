using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Elements
{
    public enum ElementCustomElementState
    {
        Undefined,
        Failed,
        Uncustomized,
        Precustomized,
        Custom
    }

    public enum EventPhase
    {
        None = 0,
        CapturingPhase = 1,
        AtTarget = 2,
        BubblingPhase = 3
    }
}
