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
		public AppearanceType Appearance { get; set; }
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
				List<string> classes = new List<string>(){ CssClassMaps.ButtonAppearanceCssMap[Appearance], CssClassMaps.ButtonSizeCssMap[Size] };
				if (!CausesValidation) classes.Add("cancel");
				return string.Join(" ", classes);
			}
		}

		public Button(string text, ButtonCommand command, AppearanceType appearance = AppearanceType.Default, ButtonSize size = ButtonSize.Default, string clientId = null) : base("_Button", clientId)
		{
			Text = text;
			Appearance = appearance;
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


		public Button SetIcon(Icon icon, IconPosition position = IconPosition.Left)
		{
			Icon = icon;
			IconPosition = position;
			return this;
		}

		public Button SetAppearance(AppearanceType type)
		{
			Appearance = type;
			return this;
		}

		public Button SetSize(ButtonSize size)
		{
			Size = size;
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