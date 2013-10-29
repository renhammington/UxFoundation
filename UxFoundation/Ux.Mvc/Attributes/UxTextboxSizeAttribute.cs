using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Attributes
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	sealed class UxTextboxSizeAttribute : Attribute, IMetadataAware
	{
		readonly string width;
		readonly string height;

		/// <summary>
		/// Sets the width and height of the rendered textbox for strings only. Css style declarations. ie "*px" or "*%"
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height">Optional. Multiline textboxes only.</param>
		public UxTextboxSizeAttribute(string width, string height = null)
		{
			this.width = width;
			this.height = height;
		}

		public void OnMetadataCreated(ModelMetadata metadata)
		{
			if (width.IsNullOrEmpty() == false)
				metadata.AdditionalValues[UxAttributeKeys.TextboxSize.Width] = width;
			
			if (height.IsNullOrEmpty() == false)
				metadata.AdditionalValues[UxAttributeKeys.TextboxSize.Height] = height;
		}
	}

}
