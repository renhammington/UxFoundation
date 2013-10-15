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
    public static IDisposable UxNumericPager(this HtmlHelper htmlHelper, PagerSize size = PagerSize.Default, string clientId = null)
    {
        var pager = new NumericPager(size, clientId);
        return RenderUxDispoableWebControl(htmlHelper, pager);
    }
}