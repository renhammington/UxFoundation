using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class NavType : CssMapper
	{
		public static readonly NavType Tabs = new NavType(0, "Tabs","nav-tabs");
		public static readonly NavType Pills = new NavType(1, "Pills", "nav-pills");
		public static readonly NavType PillsStacked = new NavType(2, "Stacked Pills", "nav-pills nav-stacked");

		private NavType() { }
		private NavType(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}


}