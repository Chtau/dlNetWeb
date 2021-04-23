using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Elements
{
    public abstract class Event
    {
        public Event(string type, bool bubbles = false, bool cancelable = false, bool composed = false)
        {
            Type = type;
            Bubbles = bubbles;
            Cancelable = cancelable;
            Composed = composed;
        }

        public string Type { get; set; }
        public EventTarget Target { get; set; }
        public EventTarget SrcElement { get; set; }
        public EventTarget CurrentTarget { get; set; }
        public virtual List<EventTarget> ComposedPath()
        {
            return new List<EventTarget>();
        }
        public EventPhase Phase { get; }
        public virtual void StopPrpagation()
        {

        }
        public virtual bool CancelBubble()
        { 
            return false; 
        }
        public virtual void StopImmediatePropagation()
        {

        }
        public bool Bubbles { get; private set; }
        public bool Cancelable { get; private set; }
        public bool ReturnValue { get; private set; }
        public virtual void PreventDefault()
        {

        }
        public bool DefaultPrevented { get; private set; }
        public bool Composed { get; private set; }
        public bool IsTrusted { get; private set; }
        public DateTime TimeStamp { get; private set; }
        public void InitEvent(string type, bool bubbles = false, bool cancelable = false)
        {
            Type = type;
            Bubbles = bubbles;
            Cancelable = cancelable;
        }
    }
}
