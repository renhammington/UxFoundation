using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
	public class EditorRow : UxControl
	{
		public MvcHtmlString Label { get; set; }
		public MvcHtmlString Editor { get; set; }
		public MvcHtmlString Validation { get; set; }
		public IEnumerable<SelectListItem> DataSource { get; set; }
		public string Tooltip { get; set; }


		public EditorRow(string clientId = null) : base("_EditorRow", clientId)
		{

		}
	}
}