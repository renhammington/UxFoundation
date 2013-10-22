using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	
	public class IconRotation : CssMapper
	{
		public static readonly IconRotation Default = new IconRotation(0, "Default");
		public static readonly IconRotation Rotate90 = new IconRotation(1, "Rotate 90 degrees", "icon-rotate-90");
		public static readonly IconRotation Rotate180 = new IconRotation(3, "Rotate 180 degrees", "icon-rotate-180");
		public static readonly IconRotation Rotate270 = new IconRotation(4, "Rotate 270 degrees", "icon-rotate-270");
		public static readonly IconRotation FlipHorizontal = new IconRotation(5, "Flip horizontal", "icon-flip-horizontal");
		public static readonly IconRotation FlipVertical = new IconRotation(6, "Flip vertical", "icon-flip-vertical");

		private IconRotation() { }
		private IconRotation(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}