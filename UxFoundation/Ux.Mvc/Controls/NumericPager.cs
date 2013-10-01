using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class NumericPager : WebControl
	{
		public PagerSize Size { get; private set; }
		
		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>();
				classes.Add("pagination");
				classes.Add(CssClassMaps.PagerSizeCssMap[Size]);
				return string.Join(" ", classes);
			}
		}


		public NumericPager(PagerSize size = PagerSize.Default, string clientId = null) : base("_NumericPager", clientId)
		{
			SetSize(size);
		}


		public NumericPager SetSize(PagerSize size)
		{
			Size = size;
			return this;
		}
		
	}
}