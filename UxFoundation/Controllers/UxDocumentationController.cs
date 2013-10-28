using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ux.Mvc.ViewModels;
using Ux.Mvc.Web.UI;


namespace Ux.Mvc.Controllers
{
    public class UxDocumentationController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult DataTypes(string partial = "Date")
        {
			var examples = CreateExamples();

            ViewBag.PartialToShow = "DataTypes/_" + partial;


            return View(examples);
        }

		private Examples CreateExamples()
		{
			var examples = new Examples()
			{
				EmailAddress = "someemail@domain.com",
				EmailAddressWithAttribute = "someemail@domain.com",
				Time = DateTime.Now,
				Date = DateTime.Now,
				DateTime = DateTime.Now,
				Url = "http://www.google.com",
				UrlWithAttribute = "http://www.google.com",
				Currency = 123.456789M,
				Integer = 123456,
				Decimal = 123.456789M,
				Double = 12345.6789,
				Password = "thisisapassword123",
				Html = "<b>Radish nopal, chickweed brussels sprout celtuce winter melon.</b><ul><li>Water chestnut taro jícama chickweed </li><li>Fava bean polk ti chard, tigernut</li></ul>",
				SingleLineText = "Radish nopal, chickweed brussels sprout celtuce winter melon. Water chestnut taro jícama chickweed chicory; scorzonera beetroot. Fava bean polk ti chard, tigernut - napa cabbage arracacha black-eyed pea. American groundnut brinjal catsear tinda; ahipa bitter gourd ceylon spinach, fiddlehead? Mustard arracacha water chestnut bell pepper. Mustard chinese artichoke tigernut mizuna greens chrysanthemum leaves.",
				MultiLineText = @"Napa cabbage tomato dolichos bean lotus root tarwi pumpkin brussels sprout lentil spring onion. Lotus root fava bean brussels sprout leaves arracacha; brussels sprout bamboo shoot spring onion. Sierra Leone bologi black-eyed pea beet greens. Mustard ulluco winter purslane. Prairie turnip yarrow indian pea - eggplant lotus root garlic celtuce greater plantain kurrat winter purslane." + Environment.NewLine + Environment.NewLine + "Gobo yardlong bean celeriac tomato chickweed carrot. Napa cabbage camas prussian asparagus, ensete garden rocket lotus root gumbo taro velvet bean.",
				ImageUrl = "https://www.google.com/images/srpr/logo4w.png",
				Boolean = true,
				BooleanNullable = null,
				BooleanByType = false,
				BooleanExplicit = true,
				BooleanNullableByType = null,
				BooleanNullableExplicit = false,
				ForeignKeyValue = "4",
				ForeignKeyValue2 = "3"
			};
			LoadDataSources(examples);
			return examples;
		}


        private void LoadDataSources(Examples model)
        {
            // Foreign key values need a data source to derive from when editing
            var phonetics = new List<SelectOption>() {
				new SelectOption("Alpha","1"),
				new SelectOption("Bravo", "2"),
				new SelectOption("Charlie","3"),
				new SelectOption("Delta","4"),
				new SelectOption("Echo", "5"),
				new SelectOption("Foxtrot","6"),
                new SelectOption("Golf", "7")
			};

            var brands = new List<SelectOption>() {
				new SelectOption("Apple", "1", iconType:IconType.Apple),
				new SelectOption("Windows","2", iconType:IconType.Windows, subText:"Microsoft"),
				new SelectOption("Github","3", iconType:IconType.Github, disabled:true),
                new SelectOption("Divider","", divider:true),
				new SelectOption("Pinterest","4", iconType:IconType.Pinterest) ,
				new SelectOption("Twitter","5", iconType:IconType.Twitter) ,
                new SelectOption("Facebook","6", iconType:IconType.Facebook) ,
                new SelectOption("Youtube","7", iconType:IconType.YoutubePlay, subText:"Google")
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
        public ActionResult DataTypes(string partial, Examples examples, ButtonCommand command)
        {
			//if (command == ButtonCommand.Cancel)
			//	Response.Redirect("http://www.google.com");

			//if (ModelState.IsValid == false) return View(examples);

            // Get the original object
            // call the right method on the domain object

            //var db = string;

            //var original = db.FindById(note.Id);
            //// concurrency check
            //// if ok

            //orignal.changeName(note.name);
            //db.SaveChanges();
			ViewBag.PartialToShow = "DataTypes/_" + partial;
			LoadDataSources(examples);

            return View(examples);
        }


        public ActionResult HtmlHelpers(string partial = "Abbreviations")
        {
            var note = new Examples()
            {
                Boolean = true,
                BooleanNullable = null,
                ForeignKeyValue = "4",
                SingleLineText = "This is a single line of text",
                EmailAddress = "renhammington@gmail.com"
            };

            ViewBag.PartialToShow = "WebControls/_" + partial;


            return View(note);
        }


        public ActionResult Configuration()
        {
            return View();
        }



        public ActionResult Files()
        {

            var examples = new Examples();
            return View(examples);
        }



        [HttpPost]
        public ActionResult Files(Examples examples)
        {
            //workingFile = new Test();
            if (ModelState.IsValid)
            {
                if (examples.AttachmentOne.HasNewFile)
                {
                    examples.Name = examples.AttachmentOne.UploadedFile.FileName;

                    //    workingFile.MyFile.FileMimeType = file.ContentType;
                    //    workingFile.MyFile.FileData = new byte[file.ContentLength];
                    //    workingFile.MyFile.Filename = file.FileName;
                    //    workingFile.MyFile.Extension = Path.GetExtension(file.FileName);
                    //    file.InputStream.Read(workingFile.MyFile.FileData, 0, file.ContentLength);
                    //    return File(workingFile.MyFile.FileData, workingFile.MyFile.FileMimeType, string.Format("blah.{0}", workingFile.MyFile.Extension));
                }
                if (examples.AttachmentTwo.HasNewFile)
                {
                    examples.Name += examples.AttachmentTwo.UploadedFile.FileName;
                }
            }

            //if (ModelState.IsValid)
            //{
            //    workingFile = new Test();
            //    if (test.MyFile != null)
            //    {
            //        workingFile.MyFile.FileMimeType = test.MyFile.UploadedFile.ContentType;
            //        workingFile.MyFile.FileData = new byte[test.MyFile.UploadedFile.ContentLength];
            //        workingFile.MyFile.Filename = test.MyFile.UploadedFile.FileName;
            //        workingFile.MyFile.Extension = Path.GetExtension(test.MyFile.UploadedFile.FileName);
            //        test.MyFile.UploadedFile.InputStream.Read(workingFile.MyFile.FileData, 0, test.MyFile.UploadedFile.ContentLength);
            //    }

            //    if (test.MyAttachment != null)
            //    {
            //        workingFile.MyAttachment.FileMimeType = test.MyAttachment.UploadedFile.ContentType;
            //        workingFile.MyAttachment.FileData = new byte[test.MyAttachment.UploadedFile.ContentLength];
            //        workingFile.MyAttachment.Filename = test.MyAttachment.UploadedFile.FileName;
            //        workingFile.MyAttachment.Extension = Path.GetExtension(test.MyAttachment.UploadedFile.FileName);
            //        test.MyAttachment.UploadedFile.InputStream.Read(workingFile.MyAttachment.FileData, 0, test.MyAttachment.UploadedFile.ContentLength);
            //    }
            //}

            return View(examples);
        }


        //public FileContentResult GetFile(int productId)
        //{
        //    var file = new FileUpload();
        //    return File(file.FileData, file.FileMimeType);
        //}


        public ActionResult ViewModels()
        {
            return View();
        }


        public ActionResult About()
        {
            return View();
        }

        public ActionResult Samples(string partial = "Tables")
        {
            ViewBag.PartialToShow = "Samples/_" + partial;
            return View();
        }


    }
}
