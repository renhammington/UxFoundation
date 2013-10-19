using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    public class RadioButton : UxControl
    {
        public string Label { get; private set; }
        public LabelPosition LabelPosition { get; private set; }
        public CheckColor Color { get; private set; }
        public string Group { get; private set; }
        public bool Selected { get; private set; }
        public string Value { get; private set; }
        public bool Disabled { get; set; }

        public RadioButton(string label, 
            string group, 
            string value = "", 
            bool selected = false, 
            LabelPosition position = UI.LabelPosition.Right, 
            CheckColor color = CheckColor.Blue,
            bool disabled = false,
            string clientId = null) : base("_RadioButton",clientId)
        {
            SetGroup(group)
                .SetSelected(selected)
                .SetLabel(label, position)
                .SetColor(color)
                .SetValue(value)
                .SetDisabled(disabled);        
        }

        public RadioButton SetGroup(string group)
        {
            Group = group;
            return this;
        }

        public RadioButton SetSelected(bool selected)
        {
            Selected = selected;
            return this;
        }

        public RadioButton SetDisabled(bool disabled)
        {
            Disabled = disabled;
            return this;
        }

        public RadioButton SetLabel(string text, LabelPosition position)
        {
            Label = text;
            LabelPosition = position;
            return this;
        }



        public RadioButton SetColor(CheckColor color)
        {
            Color = color;
            return this;
        }

        public RadioButton SetValue(string value)
        {
            Value = value;
            return this;
        }
    }
}