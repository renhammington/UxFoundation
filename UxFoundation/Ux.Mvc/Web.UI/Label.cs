using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Web.UI
{
	public class Label : WebControl
	{
		public string Text { get; private set; }
		public AppearanceType Appearance { get; private set; }

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "label", CssClassMaps.LabelAppearanceCssMap[Appearance] };
				return string.Join(" ", classes);
			}
		}

		public Label(string text, AppearanceType appearance = AppearanceType.Default, string clientId = null) : base("_Label", clientId)
		{
			SetText(text).SetAppearance(appearance);
		}

		public Label SetText(string text)
		{
			Text = text;
			return this;
		}
		public Label SetAppearance(AppearanceType appearance)
		{
			Appearance = appearance;
			return this;
		}



	}
}