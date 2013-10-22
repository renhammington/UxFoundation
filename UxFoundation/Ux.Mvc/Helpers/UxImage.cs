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
    public static MvcHtmlString UxImage(this HtmlHelper helper, string src, string alt = null, ImageBox box = null, string width = null, string height = null, string clientId = null)
    {
        var image = new Image(src, alt, box, width, height, clientId);
        return helper.RenderUxControl(image);
    }
}