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
    public static IDisposable UxNav(this HtmlHelper htmlHelper, NavType type, bool justified = false, bool affix = false, int affixOffset = 0, string clientId = null)
    {
        var pager = new Nav(type, justified, affix, affixOffset, clientId);
        return RenderUxDispoableWebControl(htmlHelper, pager);
    }
}