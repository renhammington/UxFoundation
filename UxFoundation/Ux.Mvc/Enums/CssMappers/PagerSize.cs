using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{

	public class PagerSize : CssMapper
	{
		public static readonly PagerSize Default = new PagerSize(0, "Default");
		public static readonly PagerSize Small = new PagerSize(1, "Small", "pagination-sm");
		public static readonly PagerSize Large = new PagerSize(2, "Large", "pagination-lg");

		private PagerSize() { }
		private PagerSize(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}