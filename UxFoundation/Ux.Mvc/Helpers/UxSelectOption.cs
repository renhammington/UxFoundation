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
    public static MvcHtmlString UxSelectOption(this HtmlHelper htmlHelper, string text, string value, bool selected = false, IconType? iconType = null, string subText = null, bool divider = false, bool disabled = false, string clientId = null)
    {
        var option = new SelectOption(text, value, selected, iconType, subText, divider, disabled, clientId);
        return UxSelectOption(htmlHelper, option);

    }

    public static MvcHtmlString UxSelectOption(this HtmlHelper htmlHelper, SelectOption option)
    {
        return htmlHelper.RenderUxControl(option);
    }

}