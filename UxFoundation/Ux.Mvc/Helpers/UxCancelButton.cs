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
    public static MvcHtmlString UxCancelButton(this HtmlHelper helper, ButtonSize size = null, string clientId = null)
    {
        var button = new Button("Cancel", ButtonCommand.Cancel)
            .SetValidation(false)
            .SetSize(size);
        button.SetClientId(clientId);
        return UxButton(helper, button);
    }
}