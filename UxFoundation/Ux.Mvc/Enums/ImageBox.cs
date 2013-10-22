using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    
	public class ImageBox : CssMapper
	{
		public static readonly ImageBox None = new ImageBox(0, "None");
		public static readonly ImageBox Rounded = new ImageBox(1, "Rounded", "img-rounded");
		public static readonly ImageBox Circle = new ImageBox(2, "Circle", "img-circle");
		public static readonly ImageBox Thumbnail = new ImageBox(3, "Thumbnail","img-thumbnail");

		private ImageBox() { }
		private ImageBox(int value, string displayName, string cssClass= null)
			: base(value, displayName, cssClass) { }

	}
}