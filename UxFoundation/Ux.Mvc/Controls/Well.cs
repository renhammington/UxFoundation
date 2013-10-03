using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class Well : UxControl
	{
		public WellSize Size { get; private set; }
		
		public Well(WellSize size = WellSize.Default, string clientId = null)
			: base("_Well", clientId)
		{
			SetSize(size);	
		}

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "well", CssClassMaps.WellSizeCssMap[Size] };
				return string.Join(" ", classes);
			}
		}

		public Well SetSize(WellSize size)
		{
			Size = size;
			return this;
		}


	}
}