using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    public class Table : UxControl
    {

        public bool Striped { get; private set; }
        public bool Bordered { get; private set; }
        public bool Condensed { get; private set; }
        public bool Hovered { get; private set; }

        public string CssClass
        {
            get
            {
                List<string> classes = new List<string>() { "table" };
                if (Striped) classes.Add("table-striped");
                if (Bordered) classes.Add("table-bordered");
                if (Condensed) classes.Add("table-condensed");
                if (Hovered) classes.Add("table-hover");
                return string.Join(" ", classes);
            }
        }



        public Table(bool striped = false, bool bordered = false, bool condensed = false, bool hovered = false, string clientId = null) : base("_Table", clientId)
        {
            SetStriped(striped)
                .SetCondensed(condensed)
                .SetBordered(bordered)
                .SetHovered(hovered);
        }

        public Table SetStriped(bool value)
        {
            Striped = value;
            return this;
        }

        public Table SetBordered(bool value)
        {
            Bordered = value;
            return this;
        }

        public Table SetCondensed(bool value)
        {
            Condensed = value;
            return this;
        }

        public Table SetHovered(bool value)
        {
            Hovered = value;
            return this;
        }

    }
}