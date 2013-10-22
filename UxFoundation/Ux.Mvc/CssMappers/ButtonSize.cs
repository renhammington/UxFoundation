using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{

	public class ButtonSize : CssMapper
	{
		public static readonly ButtonSize Default = new ButtonSize(0, "Default");
		public static readonly ButtonSize Large = new ButtonSize(1, "Large", "btn-lg");
		public static readonly ButtonSize Small = new ButtonSize(3, "Small", "btn-sm");
		public static readonly ButtonSize ExtraSmall = new ButtonSize(4, "Extra small", "btn-xs");
		

		private ButtonSize() { }
		private ButtonSize(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}