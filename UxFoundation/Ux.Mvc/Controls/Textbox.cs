using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
	public class Textbox : UxControl
	{

		public string Text { get; private set; }
		public string Placeholder { get; private set; }
		
		/// <summary>
		/// Css Width description
		/// </summary>
		public string Width { get; private set; }
		/// <summary>
		/// Css Height description
		/// </summary>
		public string Height { get; private set; }

		public bool MultiLine { get; private set; }

		public TextboxSize Size { get; private set; }
		public GridSize GridSize { get; private set; }
		public bool AutoComplete { get; private set; }

		public int? Rows { get; private set; }
		public string HelpText { get; private set; }
		
		public Textbox(string text, string placeholder = null, 
			bool multiLine = false, int? rows = null,
			TextboxSize size = null, GridSize gridSize = null, 
			string width = null, string height = null, 
			string helpText = null, 
			string clientId = null) : base("_Textbox",clientId)
		{
			SetText(text)
				.SetPlaceholder(placeholder)
				.SetMultiLine(multiLine, rows)
				.SetSize(size, gridSize, width, height)
				.SetHelpText(helpText);
		}


		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "form-control", Size.CssClass };
				return string.Join(" ", classes);
			}
		}

		public MvcHtmlString GetGridWrapperStart()
		{
			if (GridSize == GridSize.NotSet) return null;
			return MvcHtmlString.Create(string.Format("<div class=\"{0}\">", GridSize.CssClass));
		}

		public MvcHtmlString GetGridWrapperEnd()
		{
			if (GridSize == GridSize.NotSet) return null;
			return MvcHtmlString.Create("</div>");
		}

		public MvcHtmlString GetAttributes()
		{
			List<string> properties = new List<string>();
			if (MultiLine && Rows.HasValue) properties.Add(CreateProperty("rows",Rows.Value.ToString()));
			
			List<string> styles = new List<string>();
			if (Width.IsNullOrEmpty() == false) styles.Add(string.Format("width:{0}",Width));
			if (Height.IsNullOrEmpty() == false) styles.Add(string.Format("height:{0}", Height));
			if (styles.Count > 0) properties.Add(CreateProperty("style", string.Join(";",styles)));
			if (AutoComplete == false) properties.Add(CreateProperty("autocomplete", "off"));
		
			return MvcHtmlString.Create(string.Join(" ", properties));
		}

		public Textbox SetHelpText(string helpText)
		{
			HelpText = helpText;
			return this;
		}

		public Textbox SetSize(TextboxSize size = null, GridSize gridSize = null, string width = null, string height= null)
		{
			Size = size ?? TextboxSize.Default;
			GridSize = gridSize ?? GridSize.NotSet;
			Width = width;
			Height = height;
			return this;
		}

		public Textbox SetMultiLine(bool multiLine, int? rows = null)
		{
			MultiLine = multiLine;
			Rows = rows;
			return this;
		}

		public Textbox SetPlaceholder(string text)
		{
			Placeholder = text;
			return this;
		}
		
		public Textbox SetText(string text)
		{
			Text = text;
			return this;
		}



		


	}
}