using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace Ux.Mvc.Configuration
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate.js",
                "~/scripts/jquery.validate.unobtrusive.js"
                ));

			bundles.Add(new ScriptBundle("~/js").Include(
                "~/Scripts/app.js"
			   ));

			bundles.Add(new StyleBundle("~/css").Include(
				"~/Content/styles.less",
                 "~/Content/documentation.less"
                ));

           

			BundleTable.EnableOptimizations = false;
        }
    }
}