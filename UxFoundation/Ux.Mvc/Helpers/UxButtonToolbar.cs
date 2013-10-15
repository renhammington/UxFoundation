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
    public static IDisposable UxButtonToolbar(this HtmlHelper htmlHelper, string clientId = null)
    {
        var toolbar = new ButtonToolbar(clientId);
        return RenderUxDispoableWebControl(htmlHelper, toolbar);
    }
}