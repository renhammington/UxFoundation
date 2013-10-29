using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Ux.Mvc.Attributes;

namespace Ux.Mvc.ViewModels
{
	public class TextboxWidths : BaseViewModel
	{

		public string BaseText { get; set; }
		public TextboxWidths(string baseText = "Lorem ipsum dolor sit amet")
		{
			BaseText = baseText;
		}

		[UxTextboxSize("200px")]
		[UxPlaceholder("Blah blah blah")]
		public string SingleLinePixels { get; set; }
		
		[UxTextboxSize("70%")]
		public string SingleLinePercent { get; set; }

		[DataType(DataType.MultilineText)]
		[UxTextboxSize("200px", "200px")]
		public string MultiLinePixels { get; set; }

		[DataType(DataType.MultilineText)]
		[UxTextboxSize("60%", "100px")]
		public string MultiLineWidthHeight { get; set; }



	}
}