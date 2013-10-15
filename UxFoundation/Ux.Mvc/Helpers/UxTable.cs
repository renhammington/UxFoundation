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
    public static IDisposable UxTable(this HtmlHelper htmlHelper, bool striped = false, bool bordered = false, bool condensed = false, bool hovered = false, string clientId = null)
    {
        var table = new Table(striped, bordered, condensed, hovered, clientId);
        return RenderUxDispoableWebControl(htmlHelper, table);
    }

}