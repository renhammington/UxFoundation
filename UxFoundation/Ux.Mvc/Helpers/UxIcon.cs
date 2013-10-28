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
    /// <summary>
    /// Generates an icon using the specified CssClass. Refer to http://fontawesome.io for a list of icons
    /// </summary>
    /// <param name="helper"></param>
    /// <param name="cssClass">Font Awesome icon class</param>
    /// <returns></returns>
    public static MvcHtmlString UxIcon(this HtmlHelper helper, IconType iconType, IconSize size = null, IconRotation rotation = null, bool borderVisible = false, bool spin = false, bool pullRight = false, bool listItem = false, Popover popover = null, bool fixedWidth = false, string clientId = null)
    {
        var icon = new Icon(iconType, size, rotation, borderVisible, spin, pullRight, listItem, popover, fixedWidth, clientId);
        return UxIcon(helper, icon);
    }

    public static MvcHtmlString UxIcon(this HtmlHelper helper, Icon icon)
    {
        return helper.RenderUxControl(icon);
    }
}