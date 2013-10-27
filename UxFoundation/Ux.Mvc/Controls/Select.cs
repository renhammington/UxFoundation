using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Ux.Mvc.Web.UI
{
    public class Select : UxControl
    {

        public SelectAppearanceType Appearance { get; private set; }
        public bool LiveSearch { get; private set; }
        public bool ShowTick { get; private set; }
        public bool ShowArrow { get; private set; }
        public bool AutoWidth { get; private set; }
        public DataSource DataSource { get; private set; }
        public string SelectedValue { get; private set; }

        /// <summary>
        /// The width of the select picker. Percentage or px, ie 50% or 200px
        /// </summary>
        public string Width { get; private set; }

        /// <summary>
        /// The maximum number of items to show in the menu. Scroll will implement for longer lists.
        /// </summary>
        public int? Size { get; private set; }

        public bool Disabled { get; private set; }
        public string Header { get; private set; }
        public string Container { get; private set; }

        public string CssClass
        {
            get
            {
                List<string> classes = new List<string>() { "selectpicker" };
                if (ShowTick) classes.Add("show-tick");
                if (ShowArrow) classes.Add("show-menu-arrow");
                return string.Join(" ", classes);
            }
        }

        public MvcHtmlString GetAttributes()
        {
            List<string> properties = new List<string>();
            if (LiveSearch) properties.Add("data-live-search=\"true\"");
            properties.Add("data-style=\"" + Appearance.CssClass + "\"");
            if (AutoWidth) properties.Add("data-width=\"auto\"");
            else if (Width.IsNullOrEmpty() == false) properties.Add("data-width=\"" + Width + "\"");
            if (Header.IsNullOrEmpty() == false) properties.Add("data-header=\"" + Header + "\"");
            if (Size.HasValue) properties.Add("data-size=\"" + Size.ToString() + "\"");
            if (Disabled) properties.Add("disabled");
            if (Container.IsNullOrEmpty() == false) properties.Add("data-container=\"" + Container + "\"");

            return MvcHtmlString.Create(string.Join(" ", properties));
        }

        public Select(
            string selectedValue = null,
            DataSource datasource = null,
            SelectAppearanceType appearance = null,
            bool liveSearch = false,
            bool showTick = false,
            bool showArrow = false,
            bool autoWidth = true,
            string width = null,
            bool disabled = false,
            string header = null,
            string container = null,
            string clientId = null)
            : base("_Select", clientId)
        {
            SetSelectedValue(selectedValue)
                .SetDataSource(datasource)
                .SetAppearance(appearance)
                .SetLiveSearch(liveSearch)
                .SetTick(showTick)
                .SetArrow(showArrow)
                .SetDisabled(disabled)
                .SetHeader(header)
                .SetContainer(container);                

            if (width != null)
                SetWidth(width);
            else
                SetAutoWidth();
        }

		public Select SetAppearance(SelectAppearanceType appearance)
        {
			Appearance = appearance ?? SelectAppearanceType.Default;
            return this;
        }

        public Select SetSelectedValue(string value)
        {
            SelectedValue = value;
            return this;
        }

        public Select SetDataSource(DataSource dataSource)
        {
            DataSource = dataSource;
            return this;
        }

        public Select SetDisabled(bool value)
        {
            Disabled = value;
            return this;
        }

        public Select SetHeader(string header)
        {
            Header = header;
            return this;
        }

        public Select SetContainer(string cssSelector)
        {
            Container = cssSelector;
            return this;
        }


        public Select SetLiveSearch(bool value)
        {
            LiveSearch = value;
            return this;
        }
        public Select SetTick(bool value)
        {
            ShowTick = value;
            return this;
        }
        public Select SetArrow(bool value)
        {
            ShowArrow = value;
            return this;
        }

        public Select SetWidth(string width)
        {
            Width = width;
            AutoWidth = false;
            return this;
        }

        public Select SetAutoWidth()
        {
            AutoWidth = true;
            Width = null;
            return this;
        }









    }
}