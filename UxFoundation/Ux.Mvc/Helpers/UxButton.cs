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
    public static MvcHtmlString UxButton(this HtmlHelper helper, Button button)
    {
        return helper.RenderUxControl(button);
    }

    public static MvcHtmlString UxButton(this HtmlHelper helper,
        string text,
        ButtonAppearanceType appearance = null,
        ButtonSize size = ButtonSize.Default,
        IconType? iconType = null,
        IconPosition position = null,
        bool causesValidation = true,
        bool disabled = false,
        string loadingText = null,
        string clientId = null)
    {
        var button = new Button(text, ButtonCommand.None, appearance)
            .SetSize(size)
            .SetValidation(causesValidation)
            .SetDisabled(disabled)
            .SetLoadingText(loadingText);

        button.SetClientId(clientId);

        if (iconType.HasValue)
            button.SetIcon(new Icon(iconType.Value), position);

        return UxButton(helper, button);
    }
}