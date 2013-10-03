using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
	public class DisplayRow : UxControl
	{

		public MvcHtmlString Label { get; set; }
		public MvcHtmlString Content { get; set; }
		
		public IEnumerable<SelectListItem> DataSource { get; set; }
		
		public DisplayRow(string clientId = null)
			: base("_DisplayRow", clientId)
		{

		}
	}
}