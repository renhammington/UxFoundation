using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Attributes
{
	public class UxHintAttribute : UIHintAttribute
	{
		public UxHintAttribute(UxHintType type) : base(type.ToString())
		{
		}
	}
}