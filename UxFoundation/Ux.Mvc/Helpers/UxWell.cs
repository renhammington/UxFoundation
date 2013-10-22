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
    public static IDisposable UxWell(this HtmlHelper htmlHelper, WellSize size = null, string clientId = null)
    {
        var well = new Well(size, clientId);
        return RenderUxDispoableWebControl(htmlHelper, well);
    }
}