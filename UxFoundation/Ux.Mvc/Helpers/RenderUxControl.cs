﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Ux.Mvc.Web.UI;

public static partial class UxHtmlHelpers
{
    private static MvcHtmlString RenderUxControl(this HtmlHelper htmlHelper, UxControl control)
    {
        var partial = htmlHelper.Partial("ControlTemplates/" + control.ViewTemplate, control).ToString();
        return MvcHtmlString.Create(partial);
    }
}