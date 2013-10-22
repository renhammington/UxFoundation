using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public abstract class CssMapper : Enumeration
	{
		public string CssClass { get; protected set; }

		protected CssMapper() { }
		protected CssMapper(int value, string displayName, string cssClass = null)
			: base(value, displayName)
		{
			CssClass = cssClass;
		}

	}
}