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
    public static MvcHtmlString UxBadge(this HtmlHelper helper, string text, bool pullRight = false, string clientId = null)
    {
        var badge = new Badge(text, pullRight, clientId);
        return UxBadge(helper, badge);
    }

    public static MvcHtmlString UxBadge(this HtmlHelper helper, Badge badge)
    {
        return helper.RenderUxControl(badge);
    }
}