using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Elements
{
    public abstract class EventTarget
    {
        public void AddEventListener(string type, Action<Event> callback, Dictionary<string, string> options = null)
        {

        }

        public void RemoveEventListener(string type, Action<Event> callback, Dictionary<string, string> options = null)
        {

        }

        public void DispatchEvent(Event eventDispatch)
        {

        }
    }
}
