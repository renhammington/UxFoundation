using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Web.UI
{
    public class LinkButton : UxControl
    {

        public string Text { get; private set; }
        public string Url { get; private set; }
        public ButtonAppearanceType Appearance { get; private set; }
        public IconType IconType {get;private set;}
        public IconPosition IconPosition {get;private set;}
        public ButtonSize Size { get; private set; }
        public string Target { get; private set; }
        public Popover Popover { get; private set; }

        public string CssClass
        {
            get
            {
                List<string> classes = new List<string>() { "btn", Appearance.CssClass , Size.CssClass };
                return string.Join(" ", classes);
            }
        }

        public LinkButton(string text, string url, string target = null, ButtonAppearanceType appearance = null, ButtonSize size = null, IconType icon = null, IconPosition position = null, Popover popover = null, string clientId = null) : base("_LinkButton",clientId)
        {
            SetLink(text, url)
                .SetTarget(target)
                .SetAppearance(appearance)
                .SetIcon(icon, position)
                .SetSize(size)
                .SetPopover(popover);
        }

        public LinkButton SetLink(string text, string url)
        {
            Text = text;
            Url = url;
            return this;
        }

        public LinkButton SetPopover(Popover popover)
        {
            Popover = popover;
            return this;
        }

        public LinkButton SetSize(ButtonSize size)
        {
            Size = size ?? ButtonSize.Default;
            return this;
        }

        public LinkButton SetTarget(string target)
        {
            Target = target;
            return this;
        }

        public LinkButton SetIcon(IconType icon, IconPosition position)
        {
            IconType = icon;
            IconPosition = position ?? IconPosition.Left;
            return this;
        }

        public LinkButton SetAppearance(ButtonAppearanceType appearance)
        {
			if (appearance == null) appearance = ButtonAppearanceType.Default;
            Appearance = appearance;
            return this;
        }
    }
}