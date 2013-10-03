using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class Badge : UxControl
	{

		public string Text { get; private set; }
		public bool PullRight { get; private set; }

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "badge" };
				if (PullRight) classes.Add("pull-right");
				return string.Join(" ", classes);
			}
		}

		public Badge(string text, bool pullRight = false, string clientId = null) : base("_Badge", clientId)
		{
			SetText(text).SetPullRight(pullRight);
		}
		
		public Badge SetText(string text)
		{
			Text = text;
			return this;
		}

		public Badge SetPullRight(bool value)
		{
			PullRight = value;
			return this;
		}


	}
}