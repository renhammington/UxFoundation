using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class ButtonGroup : UxControl
	{

		public bool Toggle { get; private set; }
		public ButtonSize Size { get; private set; }
        public DataSource DataSource { get; private set; }
        public string SelectedValue { get; private set; }

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "btn-group", CssClassMaps.ButtonGroupSizeCssMap[Size] };
				return string.Join(" ", classes);
			}
		}

		public ButtonGroup(bool toggle = false, ButtonSize size = ButtonSize.Default, string selectedValue = null, DataSource dataSource = null, string clientId = null)
			: base("_ButtonGroup", clientId)
		{
			SetToggle(toggle).SetSize(size).SetDataSource(dataSource).SetSelectedValue(selectedValue);
		}

		public ButtonGroup SetToggle(bool toggle)
		{
			Toggle = toggle;
			return this;
		}

		public ButtonGroup SetSize(ButtonSize size)
		{
			Size = size;
			return this;
		}

        public ButtonGroup SetDataSource(DataSource dataSource)
        {
            DataSource = dataSource;
            return this;
        }

        public ButtonGroup SetSelectedValue(string value)
        {
            SelectedValue = value;
            return this;
        }

	}
}