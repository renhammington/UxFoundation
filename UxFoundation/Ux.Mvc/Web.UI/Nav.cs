using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class Nav : WebControl
	{
		public NavType Type {get;private set;}
		public bool Justified { get; private set; }
		public bool Affix { get; private set; }
		public int AffixOffset { get; private set; }

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "nav", CssClassMaps.NavTypeCssMap[Type] };
				if (Justified) classes.Add("nav-justified");
				return string.Join(" ", classes);
			}
		}

		public Nav(NavType type, bool justified = false, bool affix = false, int affixOffset = 0, string clientId = null)
			: base("_Nav", clientId)
		{
			SetType(type)
				.SetJustified(justified)
				.SetAffix(affix,affixOffset);
		}

		public Nav SetType(NavType type)
		{
			Type = type;
			return this;
		}

		public Nav SetJustified(bool justified)
		{
			Justified = justified;
			return this;
		}
		public Nav SetAffix(bool affix, int affixOffset)
		{
			Affix = affix;
			AffixOffset = affixOffset;
			return this;
		}

	}
}