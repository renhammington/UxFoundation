using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Web.UI
{
    public class SelectGroup : UxControl
    {

        public string Label { get; private set; }
        public bool Disabled { get; private set; }

        public MvcHtmlString GetAttributes()
        {
            List<string> properties = new List<string>();
            properties.Add("label=\"" + Label + "\"");
            if (Disabled) properties.Add("disabled");
            return MvcHtmlString.Create(string.Join(" ", properties));
        }

        public SelectGroup(string label, bool disabled = false, string clientId = null) : base("_SelectGroup", clientId)
        {
            SetLabel(label).SetDisabled(disabled);
        }

        public SelectGroup SetLabel(string label)
        {
            Label = label;
            return this;
        }

        public SelectGroup SetDisabled(bool disabled)
        {
            Disabled = disabled;
            return this;
        }

    }
}