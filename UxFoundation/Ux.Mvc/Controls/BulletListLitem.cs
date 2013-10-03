using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class BulletListItem : UxControl
	{

		public string Text { get; set; }
		
		public IconType? IconType { get; set; }
		
		public BulletListItem(string text, IconType? iconType = null, string clientId = null)
			: base("_BulletListItem", clientId)
		{
			Text = text;
			IconType = iconType;
		}
	
	}
}