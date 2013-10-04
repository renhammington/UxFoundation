using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
    public class CloseButton : UxControl
    {

        public bool CloseAlert { get; set; }
        
        public MvcHtmlString GetAttributes()
        {
            List<string> properties = new List<string>();
            if (CloseAlert) properties.Add("data-dismiss=\"alert\"");
            return MvcHtmlString.Create(string.Join(" ", properties));
        }

        public CloseButton(bool closeAlert = false, string clientId = null) : base("_CloseButton",clientId)
        {
            SetCloseAlert(closeAlert);   
        }

        public CloseButton SetCloseAlert(bool value)
        {
            CloseAlert = value;
            return this;
        }
    }
}