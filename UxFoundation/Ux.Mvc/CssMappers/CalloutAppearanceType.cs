using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class CalloutAppearanceType : CssMapper
	{
		public static readonly CalloutAppearanceType Success = new CalloutAppearanceType(2, "Success", "callout-success");
		public static readonly CalloutAppearanceType Info = new CalloutAppearanceType(2, "Info", "callout-info");
		public static readonly CalloutAppearanceType Warning = new CalloutAppearanceType(2, "Warning", "callout-warning");
		public static readonly CalloutAppearanceType Danger = new CalloutAppearanceType(2, "Danger", "callout-danger");

		private CalloutAppearanceType() { }
		private CalloutAppearanceType(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}

}