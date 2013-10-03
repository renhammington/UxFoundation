using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class Icon : UxControl
	{
		public IconSize Size { get; private set; }
		public IconRotation Rotation { get; private set; }
		public bool BorderVisible { get; private set; }
		public bool Spin { get; private set; }
		public bool PullRight { get; private set; }
		public bool ListItem { get; private set; }

		// The css class to use for the icon
		private IconType IconType { get; set; }

		/// <summary>
		/// The complete list of Css classes required to render the icon
		/// </summary>
		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { CssClassMaps.IconCssMap[IconType], CssClassMaps.IconRotationCssMap[Rotation], CssClassMaps.IconSizeCssMap[Size] };
				if (BorderVisible) classes.Add("icon-border");
				if (Spin) classes.Add("icon-spin");
				if (PullRight) classes.Add("pull-right");
				if (ListItem) classes.Add("icon-li");
				return string.Join(" ", classes);
			}
		}

		


		public Icon(IconType iconType, IconSize size = IconSize.Default, IconRotation rotation = IconRotation.Default, bool borderVisible = false, bool spin = false, bool pullRight = false, bool listItem = false, string clientId = null) : base("_Icon", clientId)
		{
			SetBorderVisible(borderVisible)
				.SetSize(size)
				.SetRotation(rotation)
				.SetType(iconType)
				.SetSpin(spin)
				.SetPullRight(pullRight)
				.SetListItem(listItem);
			
		}

		public Icon SetSize(IconSize size)
		{
			Size = size;
			return this;
		}
		public Icon SetRotation(IconRotation rotation)
		{
			Rotation = rotation;
			return this;
		}
		public Icon SetBorderVisible(bool visible)
		{
			BorderVisible = visible;
			return this;
		}
		public Icon SetSpin(bool spin)
		{
			Spin = spin;
			return this;
		}

		public Icon SetPullRight(bool pullRight)
		{
			PullRight = pullRight;
			return this;
		}

		public Icon SetType(IconType type)
		{
			IconType = type;
			return this;
		}

		public Icon SetListItem(bool listItem)
		{
			ListItem = listItem;
			return this;
		}

	}
}