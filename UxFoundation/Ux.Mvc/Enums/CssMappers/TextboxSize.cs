using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class TextboxSize : CssMapper
	{
		public static readonly TextboxSize Default = new TextboxSize(0, "Default");
		public static readonly TextboxSize Small = new TextboxSize(1, "Small", "input-sm");
		public static readonly TextboxSize Large = new TextboxSize(2, "Large", "input-lg");

		private TextboxSize() { }
		private TextboxSize(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}