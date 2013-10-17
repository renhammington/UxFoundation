using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
    public class Tooltip
    {
        public string Text { get; private set; }
        public TooltipPlacement Placement { get; private set; }

        public Tooltip(string text, TooltipPlacement placement = TooltipPlacement.Auto)
        {
            Text = text;
            Placement = placement;
        }

        public MvcHtmlString ToHtmlString()
        {
            List<string> properties = new List<string>();
            properties.Add(CreateProperty("toggle", "tooltip"));
            properties.Add(CreateProperty("title", Text));
            properties.Add(CreateProperty("placement", Placement.ToString().ToLower()));
            return MvcHtmlString.Create(string.Join(" ", properties));
        }

        private string CreateProperty(string name, string value)
        {
            return string.Format("data-{0}=\"{1}\"", name, value);
        }


    }
}