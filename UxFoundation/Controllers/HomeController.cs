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
            return RedirectToAction("Index", "UxDocumentation");
            //var test = new Test();
            //test.Birthday = DateTime.Today;
            ////test.fk = 4;
            //LoadDataSources(test);
            //return View(test);
        }

        private void LoadDataSources(Test model)
        {
            // Foreign key values need a data source to derive from when editing
            var phonetics = new List<SelectOption>() {
				new SelectOption("Alpha","1"),
				new SelectOption("Bravo", "2"),
				new SelectOption("Charlie","3"),
				new SelectOption("Delta","4"),
				new SelectOption("Echo", "5"),
				new SelectOption("Foxtrot","6"),
                new SelectOption("Golf", "6")
			};

            var brands = new List<SelectOption>() {
				new SelectOption("Apple", "1", iconType:IconType.Apple),
				new SelectOption("Windows","2", iconType:IconType.Windows, subText:"Microsoft"),
				new SelectOption("Github","3", iconType:IconType.Github, disabled:true),
                new SelectOption("Divider","2", divider:true),
				new SelectOption("Pinterest","3", iconType:IconType.PinterestSign, selected:true) ,
				new SelectOption("Twitter","4", iconType:IconType.Twitter) ,
                new SelectOption("Facebook","5", iconType:IconType.Facebook) ,
                new SelectOption("Youtube","6", iconType:IconType.YoutubePlay, subText:"Google")
			};

            var grouped = new Dictionary<string, IEnumerable<SelectOption>>() {
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