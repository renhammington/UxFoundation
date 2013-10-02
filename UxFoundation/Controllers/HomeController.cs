using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ux.Mvc.ViewModels;
using Ux.Mvc.Web.UI;


namespace Ux.Mvc.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var test = new Test();
            test.Birthday = DateTime.Today;
            //test.fk = 4;
            LoadDataSources(test);
            return View(test);
        }

        private void LoadDataSources(Test model)
        {
            // Foreign key values need a data source to derive from when editing
            var phonetics = new List<SelectListItem>() {
				new SelectListItem() { Text = "Alpha", Value="1" },
				new SelectListItem() { Text = "Bravo", Value="2" },
				new SelectListItem() { Text = "Charlie", Value="3" },
				new SelectListItem() { Text = "Delta", Value="4" },
				new SelectListItem() { Text = "Echo", Value="5" },
				new SelectListItem() { Text = "Foxtrot", Value="6" },
                new SelectListItem() { Text = "Golf", Value="6" },
			};

            var brands = new List<SelectOption>() {
				new SelectOption() { Text = "Apple", Value="1", IconType = IconType.Apple },
				new SelectOption() { Text = "Windows", Value="2", IconType = IconType.Windows, SubText="Microsoft" },
				new SelectOption() { Text = "Github", Value="5", IconType = IconType.Github, Disabled=true},
                new SelectOption() { Divider = true },
				new SelectOption() { Text = "Pinterest", Value="6", IconType = IconType.Pinterest, Disabled = true },
				new SelectOption() { Text = "Twitter", Value="3", IconType = IconType.Twitter },
                new SelectOption() { Text = "Facebook", Value="6", IconType = IconType.Facebook },                
                new SelectOption() { Text = "Youtube", Value="4", IconType = IconType.Youtube, SubText = "Google" }
			};

            var grouped = new Dictionary<string, IEnumerable<SelectListItem>>() {
				{ "Phonetics", phonetics },
				{ "Brands", brands }
			};

            // In your HtmlHelper call, you need to reference the name of the data source
            model.DataSources.Add("ungrouped", new DataSource(phonetics));
            model.DataSources.Add("brands", new DataSource(brands));
            model.DataSources.Add("grouped", new DataSource(grouped));
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
            LoadDataSources(test);
            return View(test);
        }

    }
}