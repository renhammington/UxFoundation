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
	
	public static MvcHtmlString UxTextbox(this HtmlHelper helper,
		string text,
		string placeholder = null,
		bool multiLine = false,
		int? rows = null,
		TextboxSize size = null,
		GridSize gridSize = null,
		string width = null,
		string height = null,
		string helpText = null,
		string clientId = null)
	{
		var textbox = new Textbox(text, placeholder,
			multiLine, rows, size, gridSize,
			width, height, helpText, clientId);
		return helper.RenderUxControl(textbox);
	}
}