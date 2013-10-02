using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Web.UI
{
    public class SelectOption : SelectListItem
    {
        public IconType? IconType { get; set; }
        public string SubText { get; set; }
        public bool Divider { get; set; }
        public bool Disabled { get; set; }

        public SelectOption() : base()
        {
            Divider = false;
            Disabled = false;
        }

        public MvcHtmlString GetPropertiesString()
        {
            List<string> properties = new List<string>();
            if (Disabled) properties.Add("disabled=\"disabled\"");
            if (Divider) properties.Add("data-divider=\"true\"");
            if (SubText.IsNullOrEmpty() == false) properties.Add("data-subtext=\"" + SubText + "\"");
            if (IconType.HasValue) properties.Add("data-icon=\"icon-" + CssClassMaps.IconCssMap[IconType.Value] + "\"");
            return MvcHtmlString.Create(string.Join(" ", properties));
        }


    }
}