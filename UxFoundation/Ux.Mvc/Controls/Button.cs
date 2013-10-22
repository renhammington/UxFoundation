using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
	public class Button : UxControl
	{
		public string Text { get; set; }
		public ButtonAppearanceType Appearance { get; set; }
		public ButtonSize Size { get; set; }
		public ButtonCommand Command { get; set; }
		public bool CausesValidation { get; set; }
		public Icon Icon { get; set; }
		public IconPosition IconPosition { get; set; }
		public bool Disabled { get; set; }
		public string LoadingText { get; private set; }
				
		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>(){ Appearance.CssClass, Size.CssClass };
				if (!CausesValidation) classes.Add("cancel");
				return string.Join(" ", classes);
			}
		}

		public Button(string text, ButtonCommand command, ButtonAppearanceType appearance = null, ButtonSize size = null, string clientId = null) 
			: base("_Button", clientId)
		{
			Text = text;
			SetAppearance(appearance);
			SetSize(size);
			Command = command;
			CausesValidation = true;
			Disabled = false;
		}

		public Button SetValidation(bool validate)
		{
			CausesValidation = validate;
			return this;
		}


		public Button SetIcon(Icon icon, IconPosition position = null)
		{
			Icon = icon;
			IconPosition = position ?? IconPosition.Left;
			return this;
		}

		public Button SetAppearance(ButtonAppearanceType appearance)
		{
			Appearance = appearance ?? ButtonAppearanceType.Default;
			return this;
		}

		public Button SetSize(ButtonSize size)
		{
			Size = size ?? ButtonSize.Default;
			return this;
		}

		public Button SetDisabled(bool disabled)
		{
			Disabled = disabled;
			return this;
		}

		public Button SetLoadingText(string loadingText)
		{
			LoadingText = loadingText;
			return this;
		}

	}
}