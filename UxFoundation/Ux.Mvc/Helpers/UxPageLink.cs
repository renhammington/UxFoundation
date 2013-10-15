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
    public static MvcHtmlString UxPageLink(this HtmlHelper htmlHelper, string text, string url, bool active = false, bool disabled = false, string clientId = null)
    {
        var page = new NumericPagerPageLink(text, url, active, disabled, clientId);
        return htmlHelper.RenderUxControl(page);
    }

    public static MvcHtmlString UxPageLink(this HtmlHelper htmlHelper, IconType iconType, string url, bool active = false, bool disabled = false, string clientId = null)
    {
        var page = new NumericPagerPageLink(iconType, url, active, disabled, clientId);
        return htmlHelper.RenderUxControl(page);

    }
}