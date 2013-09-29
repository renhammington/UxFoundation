using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc
{
	public class UxViewEngine : RazorViewEngine
	{

		public UxViewEngine()
		{
			ViewLocationFormats = new[] {
				"~/Ux.Mvc/Views/{1}/{0}.cshtml",
				"~/Ux.Mvc/Views/Shared/{0}.cshtml"
			};

			PartialViewLocationFormats = new[] {
				"~/Ux.Mvc/Views/{1}/{0}.cshtml",
				"~/Ux.Mvc/Views/Shared/{0}.cshtml",
				"~/Ux.Mvc/Views/Documentation/{0}.cshtml"
			};


		}
	}
}