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
    public static MvcHtmlString UxSelectDivider(this HtmlHelper htmlHelper)
    {
        var option = new SelectOption(null, null, false, null, null, true, false);
        return UxSelectOption(htmlHelper, option);

    }
}