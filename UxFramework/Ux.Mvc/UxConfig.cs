using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ux.Mvc.Binders;
using Ux.Mvc.Helpers;



[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Ux.Mvc.UxConfig), "PreStart")]
namespace Ux.Mvc
{

    public static class UxConfig
    {
        public static void PreStart()
        {
            AddUxViewEngine();
            RegisterScriptBundes();
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

        private static void RegisterScriptBundes()
        {
            bundles.Add(new ScriptBundle("~/ux/js").Include(
                "~/scripts/jquery.globalize/globalize.js",
                GlobalizeCulture.GetCurrentCulture().Value,
                "~/scripts/jquery.validate.globalize.js",               
                "~/scripts/bootstrap.js",
                "~/scripts/bootstrap-datepicker.js",
                "~/scripts/select2.js",
                "~/Ux.Mvc/scripts/jquery.fileinput.js",
                "~/Ux.Mvc/Scripts/ux.js"
                ));
        }

        private static void RegisterStyleBundles()
        {
            bundles.Add(new StyleBundle("~/ux/css").Include(
               "~/Content/bootstrap/bootstrap.css",
               "~/Content/bootstrap-datepicker.css",
               "~/Content/css/select2.css",
               "~/Content/font-awesome.css",
               "~/Ux.Mvc/Content/styles.less"
               ));


            bundles.Add(new StyleBundle("~/ux/css/documentation").Include(
               "~/Ux.Mvc/Content/documentation.less"
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