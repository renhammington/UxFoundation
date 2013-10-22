using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class PanelAppearanceType : CssMapper
	{
		public static readonly PanelAppearanceType Default = new PanelAppearanceType(0, "Default", "panel-default");
		public static readonly PanelAppearanceType Primary = new PanelAppearanceType(1, "Primary", "panel-primary");
		public static readonly PanelAppearanceType Success = new PanelAppearanceType(2, "Success", "panel-success");
		public static readonly PanelAppearanceType Info = new PanelAppearanceType(3, "Info", "panel-info");
		public static readonly PanelAppearanceType Warning = new PanelAppearanceType(4, "Warning", "panel-warning");
		public static readonly PanelAppearanceType Danger = new PanelAppearanceType(5, "Danger", "panel-danger");

		private PanelAppearanceType() { }
		private PanelAppearanceType(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}