using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
	/// <summary>
	/// Container for use in binding against select list
	/// </summary>
	public class DataSource
	{
		public IEnumerable<SelectListItem> UnGroupedItems { get; private set; }
		public IDictionary<string, IEnumerable<SelectListItem>> GroupedItems { get; private set; }
		/// <summary>
		/// Indicates whether the datasources contains a grouped or ungrouped list of items
		/// </summary>
		public bool IsGrouped
		{
			get
			{
				if (UnGroupedItems != null) return false;
				if (GroupedItems != null) return true;
				return false;
			}
		}

		public DataSource(IDictionary<String, IEnumerable<SelectListItem>> groupedItems)
		{
			GroupedItems = groupedItems;
		}

		public DataSource(IEnumerable<SelectListItem> ungroupedItems)
		{
			UnGroupedItems = ungroupedItems;
		}


	}
}