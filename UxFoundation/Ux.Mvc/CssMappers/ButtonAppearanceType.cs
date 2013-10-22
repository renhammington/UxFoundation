using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public enum AppearanceType
	{
		Default,
		Primary,
		Success,
		Info,
		Warning,
		Danger
	}


	public class ButtonAppearanceType : CssMapper
	{
		public static readonly ButtonAppearanceType Default = new ButtonAppearanceType(0, "Default", "btn-default");
		public static readonly ButtonAppearanceType Primary = new ButtonAppearanceType(1, "Primary", "btn-primary");
		public static readonly ButtonAppearanceType Success = new ButtonAppearanceType(2, "Success", "btn-success");
		public static readonly ButtonAppearanceType Info = new ButtonAppearanceType(3, "Info", "btn-info");
		public static readonly ButtonAppearanceType Warning = new ButtonAppearanceType(4, "Warning", "btn-warning");
		public static readonly ButtonAppearanceType Danger = new ButtonAppearanceType(5, "Danger", "btn-danger");

		private ButtonAppearanceType() { }
		private ButtonAppearanceType(int value, string displayName, string cssClass = null) 
			: base(value, displayName, cssClass) { }

	}

	

}