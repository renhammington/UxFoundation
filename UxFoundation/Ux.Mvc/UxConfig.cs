using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ux.Mvc.Binders;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Ux.Mvc.Configuration.UxConfig), "PreStart")]
namespace Ux.Mvc.Configuration
{

    public static class UxConfig
    {
        public static void PreStart()
        {
            AddUxViewEngine();
            RegisterScriptBundles();
            RegisterStyleBundles();
            RegisterModelBinders();
        }

        private static void RegisterModelBinders()
        {
            ModelBinders.Binders.Add(typeof(DateTime?), new UxDateTimeModelBinder());
        }

        /// <summary>
        /// Ensures Ux editor and display templates are available in the project.
        /// </summary>
        private static void AddUxViewEngine()
        {
            ViewEngines.Engines.Add(new Ux.Mvc.UxViewEngine());
        }

        private static BundleCollection bundles
        {
            get
            {
                return BundleTable.Bundles;
            }
        }

        private static RouteCollection routes
        {
            get
            {
                return RouteTable.Routes;
            }
        }

        private static void RegisterScriptBundles()
        {
            bundles.FileSetOrderList.Clear();

            bundles.Add(new ScriptBundle("~/ux/js").Include(
                "~/scripts/bootstrap.js",
                "~/scripts/bootstrap-datepicker.js",
                "~/scripts/bootstrap-select.js",
                "~/Ux.Mvc/scripts/jquery.fileinput.js",
                "~/Ux.Mvc/scripts/prettyCheckable.js",
                "~/scripts/moment.js",
                "~/Ux.Mvc/Scripts/daterangepicker.js",
                "~/scripts/jquery.timepicker.js",
                "~/Ux.Mvc/Scripts/ux.js"
                ));

            bundles.Add(new ScriptBundle("~/ux/jquery").Include(
               "~/Scripts/jquery-{version}.js",
               "~/Scripts/jquery.validate.js",
               "~/scripts/jquery.validate.unobtrusive.js"
               ));
        }

        private static void RegisterStyleBundles()
        {
            bundles.Add(new StyleBundle("~/ux/css").Include(
               "~/Content/bootstrap/bootstrap.css",
               "~/Content/bootstrap-datepicker.css",
               "~/Content/bootstrap-select.css",
               "~/Content/fontawesome/font-awesome.css",
               "~/Ux.Mvc/Content/prettyCheckable.css",
               "~/Ux.Mvc/Content/daterangepicker-bs3.css",
               "~/Content/jquery.timepicker.css",
               "~/Ux.Mvc/Content/styles.less"
               ));
        }

        public static void RegisterRoutes()
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

    }
}