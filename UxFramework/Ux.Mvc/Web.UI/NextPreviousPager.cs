using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class NextPreviousPager : WebControl
	{
		
		public PagerPosition Position { get; private set; }
		public string PreviousText { get; private set; }
		public string NextText { get; private set; }
		public string PreviousUrl { get; private set; }
		public string NextUrl { get; private set; }
		public IconType? NextIcon { get; private set; }
		public IconType? PreviousIcon { get; private set; }

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "pager" };
				return string.Join(" ", classes);
			}
		}


		public NextPreviousPager(string nextText, string nextUrl, string prevText, string prevUrl, IconType? nextIcon = IconType.ChevronRight, IconType? prevIcon = IconType.ChevronLeft, PagerPosition position = PagerPosition.Center,  string clientId = null)
			: base("_NextPreviousPager", clientId)
		{
			SetNext(nextText, nextUrl, nextIcon).SetPrevious(prevText, prevUrl, prevIcon).SetPosition(position);
			
		}


		public NextPreviousPager SetPosition(PagerPosition position)
		{
			Position = position;
			return this;
		}

		public NextPreviousPager SetNext(string text, string url, IconType? icon)
		{
			NextUrl = url;
			NextText = text;
			NextIcon = icon;
			return this;
		}

		public NextPreviousPager SetPrevious(string text, string url, IconType? icon)
		{
			PreviousUrl = url;
			PreviousText = text;
			PreviousIcon = icon;
			return this;
		}





	}
}