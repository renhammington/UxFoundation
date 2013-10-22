using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    public class Callout : UxControl
    {

        public CalloutAppearanceType Appearance { get; private set; }

        public string CssClass
        {
            get
            {
                List<string> classes = new List<string>() { "callout", Appearance.CssClass };
                return string.Join(" ", classes);
            }
        }

        public Callout(CalloutAppearanceType appearance = null, string clientId = null) : base("_Callout",clientId)
        {
            SetAppearance(appearance);
        }

        public Callout SetAppearance(CalloutAppearanceType appearance)
        {
            Appearance = appearance ?? CalloutAppearanceType.Info;
            return this;
        }



    }
}