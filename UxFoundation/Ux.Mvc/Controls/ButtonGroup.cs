using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class ButtonGroup : UxControl
	{

		public bool Toggle { get; private set; }
		public ButtonGroupSize Size { get; private set; }
        public DataSource DataSource { get; private set; }
        public string SelectedValue { get; private set; }

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "btn-group", Size.CssClass };
				return string.Join(" ", classes);
			}
		}

		public ButtonGroup(bool toggle = false, ButtonGroupSize size = null, string selectedValue = null, DataSource dataSource = null, string clientId = null)
			: base("_ButtonGroup", clientId)
		{
			SetToggle(toggle)
				.SetSize(size)
				.SetDataSource(dataSource)
				.SetSelectedValue(selectedValue);
		}

		public ButtonGroup SetToggle(bool toggle)
		{
			Toggle = toggle;
			return this;
		}

		public ButtonGroup SetSize(ButtonGroupSize size)
		{
			Size = size ?? ButtonGroupSize.Default;
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