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
    public static Panel UxPanel(this HtmlHelper htmlHelper, PanelAppearanceType appearance = null, string clientId = null)
    {
        return new Panel(htmlHelper.ViewContext, appearance, clientId);
    }

}