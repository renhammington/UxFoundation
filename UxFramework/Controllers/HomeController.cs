using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ux.Mvc.Helpers;
using Ux.Mvc.Web.UI;
using WiseGroupContracts.ViewModels;

namespace WiseGroupContracts.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var test = new Test();
            test.Birthday = DateTime.Today;
            test.Name = GlobalizeCulture.GetCurrentCulture().Value;
            return View(test);
        }


        [HttpPost]
        public ActionResult Index(Test test, ButtonCommand command)
        {
            if (command == ButtonCommand.Save)
            {
                if (test.AttachmentTwo.HasNewFile)
                    test.Name = test.AttachmentTwo.ToString();
                else
                    test.Name = "No file was attached";

            }
            else
            {
                test.Name = "Something else";
            }

            return View(test);
        }

    }
}