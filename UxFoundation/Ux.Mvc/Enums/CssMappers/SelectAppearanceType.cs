using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class SelectAppearanceType : CssMapper
	{
		public static readonly SelectAppearanceType Default = new SelectAppearanceType(0, "Default", "btn-default");
		public static readonly SelectAppearanceType Primary = new SelectAppearanceType(1, "Primary", "btn-primary");
		public static readonly SelectAppearanceType Success = new SelectAppearanceType(2, "Success", "btn-success");
		public static readonly SelectAppearanceType Info = new SelectAppearanceType(3, "Info", "btn-info");
		public static readonly SelectAppearanceType Warning = new SelectAppearanceType(4, "Warning", "btn-warning");
		public static readonly SelectAppearanceType Danger = new SelectAppearanceType(5, "Danger", "btn-danger");

		private SelectAppearanceType() { }
		private SelectAppearanceType(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}

}