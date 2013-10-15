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
    public static MvcHtmlString UxNavLink(this HtmlHelper helper, string text, string url, IconType? iconType = null, IconPosition iconPosition = IconPosition.Left, bool active = false, bool disabled = false, bool iconPullRight = false, DataToggle dataToggle = DataToggle.None, string badgeText = null, bool badgePullRight = false, string clientId = null)
    {
        var navLink = new NavLink(text, url, iconType, iconPosition, active, disabled, iconPullRight, dataToggle, clientId);
        if (badgeText != null)
            navLink.SetBadge(new Badge(badgeText, badgePullRight));

        return helper.RenderUxControl(navLink);
    }

}