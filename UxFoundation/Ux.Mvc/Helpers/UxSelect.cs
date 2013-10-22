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
	public static IDisposable UxSelect(this HtmlHelper htmlHelper, SelectAppearanceType appearance = null, bool liveSearch = false, bool showTick = false, bool showArrow = false, bool autoWidth = true, string width = null, bool disabled = false, string header = null, string container = null, string clientId = null)
    {
        var select = new Select(null, null, appearance, liveSearch, showTick, showArrow, autoWidth, width, disabled, header, container, clientId);
        return RenderUxDispoableWebControl(htmlHelper, select);
    }
}