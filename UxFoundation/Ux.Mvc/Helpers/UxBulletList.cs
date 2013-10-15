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
    public static IDisposable UxBulletList(this HtmlHelper htmlHelper, bool customIcons = false, int columnCount = 1, string clientId = null)
    {
        var list = new BulletList(customIcons, columnCount, clientId);
        return RenderUxDispoableWebControl(htmlHelper, list);
    }

}