using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    public class _Panel : UxControl
    {

        public string Title { get; private set; }
        public PanelAppearanceType Appearance { get; private set; }


        public string CssClass
        {
            get
            {
                List<string> classes = new List<string>() { "panel", Appearance.CssClass };
                return string.Join(" ", classes);
            }
        }

        public _Panel(string title = null, PanelAppearanceType appearance = null, string clientId = null)
            : base("_Panel", clientId)
        {
            SetTitle(title)
                .SetAppearance(appearance);
        }


        public _Panel SetAppearance(PanelAppearanceType appearance)
        {
            Appearance = appearance ?? PanelAppearanceType.Default;
            return this;
        }

        public _Panel SetTitle(string title)
        {
            Title = title;
            return this;
        }


    }
}