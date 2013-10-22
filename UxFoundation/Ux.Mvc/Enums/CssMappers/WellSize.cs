using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	
	public class WellSize : CssMapper
	{
		public static readonly WellSize Default = new WellSize(0, "Default");
		public static readonly WellSize Small = new WellSize(1, "Small", "well-sm");
		public static readonly WellSize Large = new WellSize(2, "Large", "well-lg");

		private WellSize() { }
		private WellSize(int value, string displayName, string cssClass = null) 
			: base(value, displayName, cssClass) { }

	}

}