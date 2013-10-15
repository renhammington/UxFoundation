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
    public static MvcHtmlString UxProgressBar(this HtmlHelper helper, int value, AppearanceType appearance = AppearanceType.Default, bool striped = false, bool animated = false, string clientId = null)
    {
        var progressBar = new ProgressBar(value, appearance, striped, animated, clientId);
        return helper.RenderUxControl(progressBar);
    }

}