using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{

	public class IconSize : CssMapper
	{
		public static readonly IconSize Default = new IconSize(0, "Default");
		public static readonly IconSize Large = new IconSize(1, "Large", "icon-large");
		public static readonly IconSize x2 = new IconSize(3, "x2", "icon-2x");
		public static readonly IconSize x3 = new IconSize(4, "x3", "icon-3x");
		public static readonly IconSize x4 = new IconSize(5, "x4", "icon-4x");

		private IconSize() { }
		private IconSize(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}