using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.ViewModels
{
	public abstract class BaseViewModel
	{
		public Dictionary<string, DataSource> DataSources { get; set; }

		public BaseViewModel()
		{
			DataSources = new Dictionary<string, DataSource>();
		}
	}
}