using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    public class Image : UxControl
    {
        /// <summary>
        /// Css width of image. ie 50% or 250px
        /// </summary>
        public string Width { get; private set; }


        /// <summary>
        /// Css height of image. ie 50% or 250px
        /// </summary>
        public string Height { get; private set; }
        public string Alt { get; private set; }
        public ImageBox ImageBox { get; private set; }
        public string Src { get; private set; }

        public string CssClass
        {
            get
            {
                List<string> classes = new List<string>() { CssClassMaps.ImageCssMap[ImageBox] };
                return string.Join(" ", classes);
            }
        }

        public string Style
        {
            get
            {
                List<string> styles = new List<string>();
                if (Width.IsNullOrEmpty() == false) styles.Add("width: " + Width);
                if (Height.IsNullOrEmpty() == false) styles.Add("height: " + Height);
                return string.Join(";", styles);
            }
        }
        public Image(string src, string alt = null, ImageBox box = UI.ImageBox.None, string width = null, string height = null, string clientId = null) : base("_Image",clientId)
        {
            SetSrc(src).SetAlt(alt).SetDimensions(width, height).SetImageBox(box);
        }

        public Image SetSrc(string src)
        {
            Src = src;
            return this;
        }

        public Image SetAlt(string alt)
        {
            Alt = alt;
            return this;
        }

        public Image SetDimensions(string width, string height)
        {
            Width = width;
            Height = height;
            return this;
        }

        public Image SetImageBox(ImageBox box)
        {
            ImageBox = box;
            return this;
        }

    }
}