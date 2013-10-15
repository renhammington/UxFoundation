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
    public static MvcHtmlString UxEditorFor<TModel, TProperty>(this HtmlHelper<TModel> helper,
          Expression<Func<TModel, TProperty>> expression,
          DataSource datasource,
          string clientId = null)
    {
        return helper.EditorFor(expression, new { DataSource = datasource });
    }
}