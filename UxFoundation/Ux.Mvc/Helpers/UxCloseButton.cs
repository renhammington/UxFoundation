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
    public static MvcHtmlString UxCloseButton(this HtmlHelper helper, bool closeAlert = false, string clientId = null)
    {
        var close = new CloseButton(closeAlert, clientId);
        return helper.RenderUxControl(close);
    }
}