using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class Alert : UxControl
	{
		public bool Dismissable { get; private set; }
		public AppearanceType Appearance { get; private set; }

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "alert", CssClassMaps.AlertAppearanceCssMap[Appearance] };
				if (Dismissable) classes.Add("alert-dismissable");
				return string.Join(" ", classes);
			}
		}

		public Alert(AppearanceType appearance = AppearanceType.Default, bool dismissable = false, string clientId = null) : base("_Alert", clientId)
		{
			SetDismissable(dismissable);
			SetAppearance(appearance);
		}

		public Alert SetDismissable(bool value)
		{
			Dismissable = value;
			return this;
		}
		public Alert SetAppearance(AppearanceType appearance)
		{
			Appearance = appearance;
			return this;
		}


	}
}