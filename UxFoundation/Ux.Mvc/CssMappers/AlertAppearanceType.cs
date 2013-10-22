using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class AlertAppearanceType : CssMapper
	{
		public static readonly AlertAppearanceType Success = new AlertAppearanceType(2, "Success", "alert-success");
		public static readonly AlertAppearanceType Info = new AlertAppearanceType(2, "Info", "alert-info");
		public static readonly AlertAppearanceType Warning = new AlertAppearanceType(3, "Warning", "alert-warning");
		public static readonly AlertAppearanceType Danger = new AlertAppearanceType(4, "Danger", "alert-danger");

		private AlertAppearanceType() { }
		private AlertAppearanceType(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}


}