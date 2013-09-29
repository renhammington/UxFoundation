using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Attributes
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	sealed class TooltipAttribute : Attribute, IMetadataAware
	{
	readonly string text;

	public TooltipAttribute(string text)
		{
			this.text = text;
		}

		public string Text
		{
			get { return text; }
		}

		public void OnMetadataCreated(ModelMetadata metadata)
		{
			metadata.AdditionalValues["tooltip"] = text;
		}
	}
}