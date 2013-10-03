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

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "btn-group", CssClassMaps.ButtonGroupSizeCssMap[Size] };
				return string.Join(" ", classes);
			}
		}

		public ButtonGroup(bool toggle = false, ButtonSize size = ButtonSize.Default, string clientId = null)
			: base("_ButtonGroup", clientId)
		{
			SetToggle(toggle).SetSize(size);
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

	}
}