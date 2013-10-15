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
    public static MvcHtmlString UxButtonGroupWithDataSource(this HtmlHelper htmlHelper, DataSource dataSource, string selectedValue = null, ButtonSize size = ButtonSize.Default, string clientId = null)
    {
        var group = new ButtonGroup(true, size, selectedValue, dataSource, clientId);

        MvcHtmlString start = htmlHelper.Partial("ControlTemplates/" + group.ViewTemplate + "Start", group);
        MvcHtmlString end = htmlHelper.Partial("ControlTemplates/" + group.ViewTemplate + "End", group);

        return MvcHtmlString.Create(start.ToHtmlString() + end.ToHtmlString());
    }
}