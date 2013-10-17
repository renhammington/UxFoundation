using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
    public class Popover
    {

        public bool IsHtml { get; private set; }
        public PopoverPlacement Placement { get; private set; }
        public PopoverTrigger Trigger { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Container { get; private set; }

        public Popover(string title, 
            string content, 
            bool isHtml = false, 
            PopoverPlacement placement = PopoverPlacement.Auto, 
            PopoverTrigger trigger = PopoverTrigger.Click, 
            string container = null)
        {
            IsHtml = isHtml;
            Title = title;
            Content = content;
            Container = container;
            Placement = placement;
            Trigger = trigger;
        }
        

        public MvcHtmlString ToHtmlString()
        {
            List<string> properties = new List<string>();
            properties.Add(CreateProperty("toggle","popover"));
            properties.Add(CreateProperty("title", Title));
            properties.Add(CreateProperty("content", Content));
            properties.Add(CreateProperty("html", IsHtml.ToString()));
            if (Container.IsNullOrEmpty() == false) properties.Add(CreateProperty("container", Container));
            properties.Add(CreateProperty("placement",Placement.ToString().ToLower()));
            properties.Add(CreateProperty("trigger",Trigger.ToString().ToLower()));
            return MvcHtmlString.Create(string.Join(" ", properties));
        }

        private string CreateProperty(string name, string value)
        {
            return string.Format("data-{0}=\"{1}\"",name,value);
        }



    }
}