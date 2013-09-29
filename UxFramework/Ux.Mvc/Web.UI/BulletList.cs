using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class BulletList : WebControl
	{
		public bool UseCustomIcons { get; private set; }
		public int ColumnCount { get; private set; }
		
		public BulletList(bool useCustomIcons = false, int columnCount = 1, string clientId = null) : base("_BulletList", clientId)
		{
			SetCustomIcons(useCustomIcons).SetColumnCount(columnCount);
		}

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>();
				if (UseCustomIcons) classes.Add("icons-ul");
				if (ColumnCount > 1 && ColumnCount <= 6)
					classes.Add("col-" + ColumnCount.ToString());
				return string.Join(" ", classes).Trim();
			}
		}

		public BulletList SetColumnCount(int columns)
		{
			ColumnCount = columns;
			return this;
		}

		public BulletList SetCustomIcons(bool value)
		{
			UseCustomIcons = value;
			return this;
		}


	}
}