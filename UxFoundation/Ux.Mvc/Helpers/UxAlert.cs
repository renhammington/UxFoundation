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
    public static IDisposable UxAlert(this HtmlHelper htmlHelper, AlertAppearanceType appearance = null, bool dismissable = false, string clientId = null)
    {
        var alert = new Alert(appearance, dismissable, clientId);
        return RenderUxDispoableWebControl(htmlHelper, alert);
    }
}