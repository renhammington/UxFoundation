using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class GridSize : CssMapper
	{
		public static readonly GridSize NotSet = new GridSize(0, "Not set", "");
		public static readonly GridSize x01 = new GridSize(1, "1-column", "col-xs-1");
		public static readonly GridSize x02 = new GridSize(2, "2-column", "col-xs-2");
		public static readonly GridSize x03 = new GridSize(3, "3-column", "col-xs-3");
		public static readonly GridSize x04 = new GridSize(4, "4-column", "col-xs-4");
		public static readonly GridSize x05 = new GridSize(5, "5-column", "col-xs-5");
		public static readonly GridSize x06 = new GridSize(6, "6-column", "col-xs-6");
		public static readonly GridSize x07 = new GridSize(7, "7-column", "col-xs-7");
		public static readonly GridSize x08 = new GridSize(8, "8-column", "col-xs-8");
		public static readonly GridSize x09 = new GridSize(9, "9-column", "col-xs-9");
		public static readonly GridSize x10 = new GridSize(10, "10-column", "col-xs-10");
		public static readonly GridSize x11 = new GridSize(11, "11-column", "col-xs-11");
		public static readonly GridSize x12 = new GridSize(12, "12-column", "col-xs-12");
		
		private GridSize() { }
		private GridSize(int value, string displayName, string cssClass = null)
			: base(value, displayName, cssClass) { }

	}
}