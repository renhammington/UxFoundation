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
    public static IDisposable UxCallout(this HtmlHelper htmlHelper, AppearanceType appearance = AppearanceType.Default, string clientId = null)
    {
        var callout = new Callout(appearance, clientId);
        return RenderUxDispoableWebControl(htmlHelper, callout);
    }
}