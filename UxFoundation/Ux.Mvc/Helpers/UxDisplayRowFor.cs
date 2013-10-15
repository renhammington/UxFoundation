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
    public static MvcHtmlString UxDisplayRowFor<TModel, TProperty>(this HtmlHelper<TModel> helper,
            Expression<Func<TModel, TProperty>> expression,
            string clientId = null)
    {
        var row = new DisplayRow(clientId)
        {
            Label = helper.LabelFor(expression, new { @class = "col-xs-3 control-label" }),
            Content = helper.DisplayFor(expression)
        };

        return RenderUxControl(helper, row);
    }
}