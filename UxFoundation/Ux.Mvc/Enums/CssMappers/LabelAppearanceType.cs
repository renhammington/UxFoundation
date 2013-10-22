using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class LabelAppearanceType : CssMapper
	{
		public static readonly LabelAppearanceType Default = new LabelAppearanceType(0, "Default", "label-default");
		public static readonly LabelAppearanceType Primary = new LabelAppearanceType(1, "Primary", "label-primary");
		public static readonly LabelAppearanceType Success = new LabelAppearanceType(2, "Success", "label-success");
		public static readonly LabelAppearanceType Info = new LabelAppearanceType(3, "Info", "label-info");
		public static readonly LabelAppearanceType Warning = new LabelAppearanceType(4, "Warning", "label-warning");
		public static readonly LabelAppearanceType Danger = new LabelAppearanceType(5, "Danger", "label-danger");

		private LabelAppearanceType() { }
		private LabelAppearanceType(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}