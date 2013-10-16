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
        public AppearanceType Appearance { get; private set; }
        public IconType? IconType {get;private set;}
        public IconPosition IconPosition {get;private set;}
        public ButtonSize Size { get; private set; }
        public string Target { get; private set; }

        public string CssClass
        {
            get
            {
                List<string> classes = new List<string>() { "btn", CssClassMaps.ButtonAppearanceCssMap[Appearance], CssClassMaps.ButtonSizeCssMap[Size] };
                return string.Join(" ", classes);
            }
        }

        public LinkButton(string text, string url, string target = null, AppearanceType appearance = AppearanceType.Default, ButtonSize size = ButtonSize.Default, IconType? icon = null, IconPosition position = IconPosition.Left,string clientId = null) : base("_LinkButton",clientId)
        {
            SetLink(text, url)
                .SetTarget(target)
                .SetAppearance(appearance)
                .SetIcon(icon, position)
                .SetSize(size);
        }

        public LinkButton SetLink(string text, string url)
        {
            Text = text;
            Url = url;
            return this;
        }

        public LinkButton SetSize(ButtonSize size)
        {
            Size = size;
            return this;
        }

        public LinkButton SetTarget(string target)
        {
            Target = target;
            return this;
        }

        public LinkButton SetIcon(IconType? icon, IconPosition position)
        {
            IconType = icon;
            IconPosition = position;
            return this;
        }

        public LinkButton SetAppearance(AppearanceType appearance)
        {
            Appearance = appearance;
            return this;
        }
    }
}