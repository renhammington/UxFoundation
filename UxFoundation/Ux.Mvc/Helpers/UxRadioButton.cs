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
    public static MvcHtmlString UxRadioButton(this HtmlHelper htmlHelper, 
        string label, 
        string group, 
        string value = "", 
        bool selected = false, 
        LabelPosition position = LabelPosition.Right, 
        CheckColor color = CheckColor.Blue, 
        string clientId = null)
    {
        var radio = new RadioButton(label, group, value, selected, position, color, clientId);
        return htmlHelper.RenderUxControl(radio);
    }
}