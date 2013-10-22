using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
    public class Panel : IDisposable
    {

        public string Title { get; private set; }
        public PanelAppearanceType Appearance { get; private set; }

        ViewContext ViewContext;
        Boolean isDisposed = false;

        public string CssClass
        {
            get
            {
                List<string> classes = new List<string>() { "panel", Appearance.CssClass };
                return string.Join(" ", classes);
            }
        }

        public Panel(ViewContext viewContext, PanelAppearanceType appearance = null, string clientId = null)
        {
            ViewContext = viewContext;
            SetAppearance(appearance);

            var open = string.Format("<div class=\"{0}\" id=\"{1}\">",CssClass, clientId);
            ViewContext.Writer.Write(open);
        }

        public void Dispose()
        {
            if (isDisposed) return;
            isDisposed = true;
            ViewContext.Writer.Write("</div>");
        }

        public MvcHtmlString Header(Func<dynamic, Object> markup)
        {
            var output = "<div class=\"panel-heading\">";
            output += markup.DynamicInvoke(ViewContext);
            output += "</div>";
            return MvcHtmlString.Create(output);
        }
        public MvcHtmlString Body(Func<dynamic, Object> markup)
        {
            var output = "<div class=\"panel-body\">";
            output += markup.DynamicInvoke(ViewContext);
            output += "</div>";
            return MvcHtmlString.Create(output);
        }
        public MvcHtmlString Footer(Func<dynamic, Object> markup)
        {
            var output = "<div class=\"panel-footer\">";
            output += markup.DynamicInvoke(ViewContext);
            output += "</div>";
            return MvcHtmlString.Create(output);
        }


        public Panel SetAppearance(PanelAppearanceType appearance)
        {
            Appearance = appearance ?? PanelAppearanceType.Default;
            return this;
        }

     


    }
}