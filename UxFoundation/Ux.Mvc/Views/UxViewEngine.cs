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
				"~/Ux.Mvc/Views/Shared/{0}.cshtml"
			};


		}
	}

	// The following class has been added to the project to ensure
	// that developers using Resharper aren't bombarded with errors
	// This is a Resharper issue, not a UxFoundation issue.
	// This class is never called or created. 
	public class StdViewEngine : RazorViewEngine
	{
		public StdViewEngine()
		{
			ViewLocationFormats = new[] {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };

			PartialViewLocationFormats = new[] {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };
		}
	}

}