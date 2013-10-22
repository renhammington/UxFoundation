using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class ButtonGroupSize : CssMapper
	{
		public static readonly ButtonGroupSize Default = new ButtonGroupSize(0, "Default");
		public static readonly ButtonGroupSize Large = new ButtonGroupSize(1, "Large", "btn-group-lg");
		public static readonly ButtonGroupSize Small = new ButtonGroupSize(3, "Small", "btn-group-sm");
		public static readonly ButtonGroupSize ExtraSmall = new ButtonGroupSize(4, "Extra small", "btn-group-xs");


		private ButtonGroupSize() { }
		private ButtonGroupSize(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}