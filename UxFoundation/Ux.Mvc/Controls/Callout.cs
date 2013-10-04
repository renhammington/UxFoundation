using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    public class Callout : UxControl
    {

        public AppearanceType Appearance { get; private set; }

        public string CssClass
        {
            get
            {
                List<string> classes = new List<string>() { "callout", CssClassMaps.CalloutCssMap[Appearance] };
                return string.Join(" ", classes);
            }
        }

        public Callout(AppearanceType appearance = AppearanceType.Default, string clientId = null) : base("_Callout",clientId)
        {
            SetAppearance(appearance);
        }

        public Callout SetAppearance(AppearanceType appearance)
        {
            Appearance = appearance;
            return this;
        }



    }
}