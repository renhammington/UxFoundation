using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    public class Abbreviation : UxControl
    {

        public string Text { get; private set; }
        public string FullText { get; private set; }

        public Abbreviation(string text, string fullText, string clientId) : base("_Abbreviation",clientId)
        {
            SetText(text, fullText);
        }

        public Abbreviation SetText(string text, string fullText)
        {
            Text = text;
            FullText = fullText;
            return this;
        }





    }
}