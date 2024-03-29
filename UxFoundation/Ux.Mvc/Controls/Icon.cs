﻿using System;
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
		public bool FixedWidth { get; private set; }
        public Popover Popover { get; private set; }

		// The css class to use for the icon
		private IconType IconType { get; set; }

		/// <summary>
		/// The complete list of Css classes required to render the icon
		/// </summary>
		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { IconType.CssClass, Rotation.CssClass, Size.CssClass };
				if (BorderVisible) classes.Add("fa-border");
				if (Spin) classes.Add("fa-spin");
				if (PullRight) classes.Add("pull-right");
				if (ListItem) classes.Add("fa-li");
				if (FixedWidth) classes.Add("fa-fw");
				return string.Join(" ", classes);
			}
		}

		


		public Icon(IconType iconType, IconSize size = null, IconRotation rotation = null, bool borderVisible = false, bool spin = false, bool pullRight = false, bool listItem = false, Popover popover = null, bool fixedWidth = false, string clientId = null) : base("_Icon", clientId)
		{
			SetBorderVisible(borderVisible)
				.SetSize(size)
				.SetRotation(rotation)
				.SetType(iconType)
				.SetSpin(spin)
				.SetPullRight(pullRight)
				.SetListItem(listItem)
				.SetPopover(popover)
				.SetFixedWidth(fixedWidth);
			
		}

		public Icon SetFixedWidth(bool fixedWidth)
		{
			FixedWidth = fixedWidth;
			return this;
		}

        public Icon SetPopover(Popover popover)
        {
            Popover = popover;
            return this;
        }

		public Icon SetSize(IconSize size)
		{
			Size = size ?? IconSize.Default;
			return this;
		}
		public Icon SetRotation(IconRotation rotation)
		{
			Rotation = rotation ?? IconRotation.Default;
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