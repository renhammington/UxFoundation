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
    public static MvcHtmlString UxAbbreviation(this HtmlHelper helper, string text, string fullText, string clientId = null)
    {
        var abbr = new Abbreviation(text, fullText, clientId);
        return helper.RenderUxControl(abbr);
    }
}