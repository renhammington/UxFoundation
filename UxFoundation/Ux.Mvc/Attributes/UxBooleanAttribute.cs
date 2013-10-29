using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Attributes
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public class UxBooleanAttribute : Attribute, IMetadataAware
	{
		public string TrueText { get; private set; }
		public string FalseText { get; private set; }
		public string NullText { get; private set; }
		public BooleanType Type { get; private set; }

		public UxBooleanAttribute(string trueText, string falseText, string nullText = "Not set")
		{
			TrueText = trueText;
			FalseText = falseText;
			NullText = nullText;
			Type = BooleanType.Custom;
		}

		public UxBooleanAttribute(BooleanType type, string nullText = "Not set")
		{
			Type = type;
			NullText = nullText;
		}

		public void OnMetadataCreated(ModelMetadata metadata)
		{
			metadata.AdditionalValues[UxAttributeKeys.Boolean.TrueText] = TrueText;
			metadata.AdditionalValues[UxAttributeKeys.Boolean.FalseText] = FalseText;
			metadata.AdditionalValues[UxAttributeKeys.Boolean.NullText] = NullText;
			metadata.AdditionalValues[UxAttributeKeys.Boolean.Type] = Type;
		}
	}
}