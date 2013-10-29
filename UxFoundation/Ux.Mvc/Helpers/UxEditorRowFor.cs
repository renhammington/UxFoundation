using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Ux.Mvc.Attributes;
using Ux.Mvc.Web.UI;

public static partial class UxHtmlHelpers
{
    public static MvcHtmlString UxEditorRowFor<TModel, TProperty>(this HtmlHelper<TModel> helper,
             Expression<Func<TModel, TProperty>> expression,
             DataSource datasource = null,
             string clientId = null)
    {

        //var placeholder = expression ;
        //var tooltip = ;
        var member = ((MemberExpression)expression.Body).Member;
        var placeholder = member.GetAttribute<UxPlaceholderAttribute>();
        var tooltip = member.GetAttribute<UxTooltipAttribute>();

        //var uiHint = member.GetAttribute<UIHintAttribute>();
        //object datasource = null;
        //object groupeddatasource = null;
        //if (uiHint != null && uiHint.UIHint == "Select")
        //{
        //	datasource = null;
        //	groupeddatasource = grouped;
        //}

        var row = new EditorRow(clientId)
        {
            Label = helper.LabelFor(expression, new { @class = "col-xs-3 control-label" }),
            Editor = helper.EditorFor(expression, new { DataSource = datasource, PlaceHolder = placeholder == null ? null : placeholder.Text }),
            Validation = helper.ValidationMessageFor(expression),
            Tooltip = tooltip == null ? null : tooltip.Text
        };

        return RenderUxControl(helper, row);
    }
}