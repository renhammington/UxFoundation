using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Attributes
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public class BooleanAttribute : Attribute, IMetadataAware
	{
		public string TrueText { get; private set; }
		public string FalseText { get; private set; }
		public string NullText { get; private set; }
		public BooleanType Type { get; private set; }

		public BooleanAttribute(string trueText, string falseText, string nullText = "Not set")
		{
			TrueText = trueText;
			FalseText = falseText;
			NullText = nullText;
			Type = BooleanType.Custom;
		}

		public BooleanAttribute(BooleanType type, string nullText = "Not set")
		{
			Type = type;
			NullText = nullText;
		}

		public void OnMetadataCreated(ModelMetadata metadata)
		{
			metadata.AdditionalValues["trueText"] = TrueText;
			metadata.AdditionalValues["falseText"] = FalseText;
			metadata.AdditionalValues["nullText"] = NullText;
			metadata.AdditionalValues["booleanType"] = Type;
		}
	}
}