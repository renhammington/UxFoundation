using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    public class LabelPosition : Enumeration
	{
		public static readonly LabelPosition Left = new LabelPosition(0, "Left");
		public static readonly LabelPosition Right = new LabelPosition(1, "Right");

		private LabelPosition() { }
		private LabelPosition(int value, string displayName)
			: base(value, displayName) { }

	}
}