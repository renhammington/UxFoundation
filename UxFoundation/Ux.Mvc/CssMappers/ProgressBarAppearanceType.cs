using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class ProgressBarAppearanceType : CssMapper
	{
		public static readonly ProgressBarAppearanceType Success = new ProgressBarAppearanceType(1, "Success", "progress-bar-success");
		public static readonly ProgressBarAppearanceType Info = new ProgressBarAppearanceType(2, "Info", "progress-bar-info");
		public static readonly ProgressBarAppearanceType Warning = new ProgressBarAppearanceType(3, "Warning", "progress-bar-warning");
		public static readonly ProgressBarAppearanceType Danger = new ProgressBarAppearanceType(4, "Danger", "progress-bar-danger");

		private ProgressBarAppearanceType() { }
		private ProgressBarAppearanceType(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}

}