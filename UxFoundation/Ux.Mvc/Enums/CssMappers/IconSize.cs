using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{

	public class IconSize : CssMapper
	{
		public static readonly IconSize Default = new IconSize(0, "Default");
		public static readonly IconSize Large = new IconSize(1, "Large", "fa-lg");
		public static readonly IconSize x2 = new IconSize(3, "x2", "fa-2x");
		public static readonly IconSize x3 = new IconSize(4, "x3", "fa-3x");
		public static readonly IconSize x4 = new IconSize(5, "x4", "fa-4x");
		public static readonly IconSize x5 = new IconSize(6, "x5", "fa-5x");

		private IconSize() { }
		private IconSize(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}