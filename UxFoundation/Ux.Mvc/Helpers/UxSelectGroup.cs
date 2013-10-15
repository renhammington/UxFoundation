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
    public static IDisposable UxSelectGroup(this HtmlHelper htmlHelper, string label, bool disabled = false, string clientId = null)
    {
        var group = new SelectGroup(label, disabled, clientId);
        return RenderUxDispoableWebControl(htmlHelper, group);
    }
}