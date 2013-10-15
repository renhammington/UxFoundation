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
    public static MvcHtmlString UxNextPrevPager(this HtmlHelper htmlHelper, string nextText = "Next", string nextUrl = null, string previousText = "Previous", string previousUrl = null, IconType? nextIcon = IconType.ChevronRight, IconType? previousIcon = IconType.ChevronLeft, PagerPosition position = PagerPosition.Center, string clientId = null)
    {
        var pager = new NextPreviousPager(nextText, nextUrl, previousText, previousUrl, nextIcon, previousIcon, position, clientId);
        return htmlHelper.RenderUxControl(pager);
    }
}