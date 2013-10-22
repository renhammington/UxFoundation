using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Web.UI
{
	public class Label : UxControl
	{
		public string Text { get; private set; }
		public LabelAppearanceType Appearance { get; private set; }

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "label", Appearance.CssClass };
				return string.Join(" ", classes);
			}
		}

		public Label(string text, LabelAppearanceType appearance = null, string clientId = null) : base("_Label", clientId)
		{
			SetText(text).SetAppearance(appearance);
		}

		public Label SetText(string text)
		{
			Text = text;
			return this;
		}
		public Label SetAppearance(LabelAppearanceType appearance)
		{
			Appearance = appearance ?? LabelAppearanceType.Default;
			return this;
		}



	}
}