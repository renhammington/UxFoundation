using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class NumericPager : UxControl
	{
		public PagerSize Size { get; private set; }
		
		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>();
				classes.Add("pagination");
				classes.Add(Size.CssClass);
				return string.Join(" ", classes);
			}
		}


		public NumericPager(PagerSize size = null, string clientId = null) : base("_NumericPager", clientId)
		{
			SetSize(size);
		}


		public NumericPager SetSize(PagerSize size)
		{
			Size = size ?? PagerSize.Default;
			return this;
		}
		
	}
}