using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Configuration
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}