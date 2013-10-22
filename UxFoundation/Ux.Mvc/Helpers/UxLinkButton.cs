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
    public static MvcHtmlString UxLinkButton(this HtmlHelper helper, string text, string url, string target = null, ButtonAppearanceType appearance = null, ButtonSize size = null, IconType icon = null, IconPosition iconPosition = null, Popover popover = null, string clientId = null)
    {
        var link = new LinkButton(text, url, target, appearance, size, icon, iconPosition, popover,clientId);
        return helper.RenderUxControl(link);
    }

}