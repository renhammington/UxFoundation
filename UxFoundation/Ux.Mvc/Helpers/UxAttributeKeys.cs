using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Attributes
{
	public class UxAttributeKeys
	{
		public class Boolean
		{
			public static readonly string TrueText = "uxTrueText";
			public static readonly string FalseText = "uxFalseText";
			public static readonly string NullText = "uxNullText";
			public static readonly string Type = "uxBooleanType";
		}
		public class Tooltip
		{
			public static readonly string Text = "uxTooltipText";
		}

		public class TextboxSize
		{
			public static readonly string Width = "uxTextboxWidth";
			public static readonly string Height = "uxTextboxHeight";
		}
		public class Placeholder
		{
			public static readonly string Text = "uxPlaceholder";
		}





	}
}