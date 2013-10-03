using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class ButtonToolbar : UxControl
	{

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "btn-toolbar" };
				return string.Join(" ", classes);
			}
		}

		public ButtonToolbar(string clientId = null)
			: base("_ButtonToolbar", clientId)
		{
		}




	}
}