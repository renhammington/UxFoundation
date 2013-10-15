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
    public static MvcHtmlString UxBulletListItem(this HtmlHelper helper, string text, IconType? iconType = null, string clientId = null)
    {
        BulletListItem bullet = new BulletListItem(text, iconType, clientId);
        return helper.RenderUxControl(bullet);
    }
}