using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.IO;

namespace Ux.Mvc.Controllers
{
    public class IconController : Controller
    {
        //
        // GET: /Icon/
        public ActionResult Index()
        {
			var json = System.IO.File.ReadAllText(Server.MapPath("~/Scripts/icons.json"));
			var icons = JsonConvert.DeserializeObject<FontAwesomeIcons>(json);
			return View(icons);
        }
	}

	public class FontAwesomeIcon
	{
		

		public string Id { get; set; }
		public string Name { get; set; }
		public List<string> Aliases = new List<string>();
		public string FixedName
		{
			get
			{
				string fixedName = Name.Replace("-", " ");
				var words = fixedName.Split(' ');
				List<string> cleanedWords = new List<string>();
				words.Where(w => w.StartsWith("(") == false).ToList().ForEach(word => cleanedWords.Add(word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower()));
				return string.Join(" ", cleanedWords);
			}
		}
	}

	public class FontAwesomeIcons
	{
		public List<FontAwesomeIcon> icons { get; set; }
	}

}