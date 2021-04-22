using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Elements
{
    // TODO: https://dom.spec.whatwg.org/#concept-element
    public abstract class BaseElement
    {
        public string Namespace { get; set; }
        public string NamespacePrefix {get;set;}
        public string LocalName { get; set; }
        public ElementCustomElementState CustomElementState { get; set; }
        public string CustomElementDefinition { get; set; }
        public bool IsValue { get; set; }
        public bool Defined => CustomElementState == ElementCustomElementState.Uncustomized || CustomElementState == ElementCustomElementState.Custom;
        public bool Custom => CustomElementState == ElementCustomElementState.Custom;
    }
}
