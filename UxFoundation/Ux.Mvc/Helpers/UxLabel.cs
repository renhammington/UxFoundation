using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Ux.Mvc.Web.UI;

public static partial class UxHtmlHelpers
{
    public static MvcHtmlString UxLabel(this HtmlHelper helper, string text, AppearanceType appearance = AppearanceType.Default, string clientId = null)
    {
        var label = new Label(text, appearance, clientId);
        return helper.RenderUxControl(label);
    }
}