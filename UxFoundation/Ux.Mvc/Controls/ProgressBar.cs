using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	public class ProgressBar : UxControl
	{

		public ProgressBarAppearanceType Appearance { get; private set; }
		public bool Striped { get; private set; }
		public bool Animated { get; private set; }
		
		/// <summary>
		/// 0 to 100
		/// </summary>
		public int Value { get; private set; }

		public string InnerCssClass
		{
			get
			{
				List<string> classes = new List<string>() { "progress-bar", Appearance.CssClass };
				return string.Join(" ", classes);
			}
		}

		public string CssClass
		{
			get
			{
				List<string> classes = new List<string>() { "progress" };
				if (Striped) classes.Add("progress-striped");
				if (Animated && Striped) classes.Add("active");
				return string.Join(" ", classes);
			}
		}


		public ProgressBar(int value, ProgressBarAppearanceType appearance = null, bool striped = false, bool animated = false, string clientId = null)
			: base("_ProgressBar", clientId)
		{
			
			SetAppearance(appearance);
			SetStriped(striped);
			SetAnimated(animated);
			SetValue(value);
		}

		public ProgressBar SetAppearance(ProgressBarAppearanceType appearance)
		{
			Appearance = appearance ?? ProgressBarAppearanceType.Success;
			return this;
		}

		public ProgressBar SetValue(int value)
		{
			if (value > 100) value = 100;
			if (value < 0) value = 0;
			Value = value;
			return this;
		}
		public ProgressBar SetAnimated(bool value)
		{
			Animated = value;
			return this;
		}
		public ProgressBar SetStriped(bool value)
		{
			Striped = value;
			return this;
		}



	}
}