using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	

	public class IconPosition : Enumeration
	{
		public static readonly IconPosition Left = new IconPosition(0, "Left");
		public static readonly IconPosition Right = new IconPosition(1, "Right");
		
		private IconPosition() { }
		private IconPosition(int value, string displayName)
			: base(value, displayName) { }

	}
}