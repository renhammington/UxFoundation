using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Web.UI
{
    public class SelectOption : WebControl 
    {
        public IconType? IconType { get; private set; }
        public string SubText { get; private set; }
        public bool Divider { get; private set; }
        public bool Disabled { get; private set; }
        public bool Selected { get; private set; }
        public string Text { get; private set; }
        public string Value { get; private set; }

        
        public SelectOption(string text, string value, bool selected = false, IconType? iconType = null, string subText = null, bool divider = false, bool disabled = false, string clientId = null) : base("_SelectOption",clientId)
        {
            SetTextAndValue(text, value)
                .SetSelected(selected)
                .SetIcon(iconType)
                .SetDivider(divider)
                .SetDisabled(disabled)
                .SetSubText(subText);
        }

        public SelectOption(SelectListItem item) : base("_SelectOption",null)
        {
            SetTextAndValue(item.Text, item.Value);
        }

        public SelectOption SetTextAndValue(string text, string value)
        {
            Text = text;
            Value = value;
            return this;
        }

        public SelectOption SetSubText(string subText)
        {
            SubText = subText;
            return this;
        }

        public SelectOption SetSelected(bool value)
        {
            Selected = value;
            return this;
        }

        public SelectOption SetIcon(IconType? iconType)
        {
            IconType = iconType;
            return this;
        }

        public SelectOption SetDivider(bool value)
        {
            Divider = value;
            return this;
        }
        public SelectOption SetDisabled(bool value)
        {
            Disabled = value;
            return this;
        }

        public MvcHtmlString GetAttributes()
        {
            List<string> properties = new List<string>();
            if (Disabled) properties.Add("disabled=\"disabled\"");
            if (Divider) properties.Add("data-divider=\"true\"");
            if (SubText.IsNullOrEmpty() == false) properties.Add("data-subtext=\"" + SubText + "\"");
            if (IconType.HasValue) properties.Add("data-icon=\"icon-" + CssClassMaps.IconCssMap[IconType.Value] + "\"");
            if (Selected) properties.Add("selected=\"selected\"");
            return MvcHtmlString.Create(string.Join(" ", properties));
        }


    }
}