using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class NumericPagerPageLink : WebControl
	{

		public string Url { get; private set; }
		public string Text {get;private set; }
		public IconType Icon { get; private set; }
		public bool Disabled { get; private set; }
		public bool Active { get; private set; }


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


		public NumericPagerPageLink(string text, string url, bool active = false, bool disabled = false, string clientId = null)
			: base("_NumericPagerPageLink", clientId)
		{
			SetText(text).SetUrl(url).SetDisabled(disabled).SetActive(active);
		}

		public NumericPagerPageLink(IconType icon, string url, bool active = false, bool disabled = false, string clientId = null)
			: base("_NumericPagerPageLink", clientId)
		{
			SetIcon(icon).SetUrl(url).SetDisabled(disabled).SetActive(active);
		}

		public NumericPagerPageLink SetUrl(string url)
		{
			Url = url;
			return this;
		}
		public NumericPagerPageLink SetText(string text)
		{
			Text = text;
			return this;
		}

		public NumericPagerPageLink SetIcon(IconType icon)
		{
			Icon = icon;
			return this;
		}

		public NumericPagerPageLink SetDisabled(bool disabled)
		{
			Disabled = disabled;
			return this;
		}

		public NumericPagerPageLink SetActive(bool active)
		{
			Active = active;
			return this;
		}

	}
}