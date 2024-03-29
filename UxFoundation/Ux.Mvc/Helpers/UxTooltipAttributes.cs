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
    public static MvcHtmlString UxTooltipAttributes(this HtmlHelper helper, string text, TooltipPlacement placement = TooltipPlacement.Auto)
    {
        var tooltip = new Tooltip(text, placement);
        return tooltip.ToHtmlString();
    }
}