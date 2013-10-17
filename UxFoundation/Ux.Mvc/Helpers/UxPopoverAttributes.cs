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
    public static MvcHtmlString UxPopoverAttributes(this HtmlHelper helper,
        string title,
        string content, 
        bool isHtml = false,
        PopoverPlacement placement = PopoverPlacement.Auto,
        PopoverTrigger trigger = PopoverTrigger.Click,
        string container = null)
    {
        var popover = new Popover(title, content, isHtml, placement, trigger, container);
        return popover.ToHtmlString();   
    }
}