using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class NavLink : UxControl
	{

		public bool Active { get; private set; }
		public bool Disabled { get; private set; }
		public string Url { get; private set; }
		public string Text { get; private set; }
		public IconType IconType { get; private set; }
		public IconPosition IconPosition { get; private set; }
		public bool IconPullRight { get; private set; }
		public DataToggle DataToggle { get; private set; }
		public Badge Badge { get; private set; }

		public NavLink(string text, 
			string url, 
			IconType icon = null, 
			IconPosition position = null, 
			bool active = false, 
			bool disabled= false,
			bool iconPullRight = false,
			DataToggle dataToggle = DataToggle.None,
			string clientId = null) : base("_NavLink", clientId)
		{
			SetText(text)
				.SetUrl(url)
				.SetIcon(icon,position, iconPullRight)
				.SetActive(active)
				.SetDisabled(disabled)
				.SetDataToggle(dataToggle);
		}

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>();
				if (Active) classes.Add("active");
				if (Disabled) classes.Add("disabled");
				return string.Join(" ", classes);
			}
		}

		public NavLink SetText(string text)
		{
			Text = text;
			return this;
		}

		public NavLink SetUrl(string url)
		{
			Url = url;
			return this;
		}

		public NavLink SetActive(bool active)
		{
			Active = active;
			return this;
		}
		
		public NavLink SetDisabled(bool disabled)
		{
			Disabled = disabled;
			return this;
		}

		public NavLink SetIcon(IconType icon, IconPosition position, bool pullRight = false)
		{
			IconType = icon;
			IconPosition = position ?? IconPosition.Left;
			IconPullRight = pullRight;
			return this;

		}

		public NavLink SetDataToggle(DataToggle toggle)
		{
			DataToggle = toggle;
			return this;
		}

		public NavLink SetBadge(Badge badge)
		{
			Badge = badge;
			return this;
		}
	}
}