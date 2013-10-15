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
    public static IDisposable UxButtonGroup(this HtmlHelper htmlHelper, bool toggle = false, ButtonSize size = ButtonSize.Default, string clientId = null)
    {
        var group = new ButtonGroup(toggle, size, null, null, clientId);
        return RenderUxDispoableWebControl(htmlHelper, group);
    }
}