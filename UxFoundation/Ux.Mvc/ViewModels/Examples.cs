using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Ux.Mvc.Attributes;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.ViewModels
{
	public class Examples : BaseViewModel
	{
		public int Id { get; set; }

		[DataType(DataType.Text)]
		[Placeholder("Enter whatever you please...")]
		public string SingleLineText { get; set; }
				
		[DataType(DataType.MultilineText)]
		[Placeholder("Lorem ipsum dolor sit amet")]
		public string MultiLineText { get; set; }
				
		[DataType(DataType.EmailAddress)]
		[Display(Name="Email using data type")]
		public string EmailAddress { get; set; }

		[EmailAddress]
		[Display(Name="Email using EmailAddress")]
		public string EmailAddressWithAttribute { get; set; }


		[DataType(DataType.Url)]
		[Tooltip("Make sure you pick something amazing")]
		public string Url { get; set; }

		[DataType(DataType.Password)]
		public string Password { get; set; }

		[DataType(DataType.Html)]
		public string Html { get; set; }

		[Url]
		[Tooltip("Make sure you pick something amazing")]
		public string UrlWithAttribute { get; set; }

		[DataType(DataType.ImageUrl)]
		public string ImageUrl { get; set; }
		

		[DataType(DataType.Date)]
		public DateTime Date { get; set; }

		[DataType(DataType.Time)]
		public DateTime Time { get; set; }

		[DataType(DataType.DateTime)]
		public DateTime DateTime { get; set; }

		public int Integer { get; set; }


		public decimal Decimal { get; set; }

		public double Double { get; set; }


		[DataType(DataType.Currency)]
		public decimal Currency { get; set; }


		[UxHint(UxHintType.Range)]
		public int Range { get; set; }



		#region Boolean

		public bool Boolean { get; set; }

		public bool? BooleanNullable { get; set; }

		[Boolean("Oui", "Non")]
		public bool BooleanExplicit { get; set; }

		[Boolean("Positive","Negative","Uncertain")]
		public bool? BooleanNullableExplicit { get; set; }

		[Boolean(BooleanType.TrueFalse)]
		public bool BooleanByType { get; set; }

		[Boolean(BooleanType.TrueFalse, "Perhaps")]
		public bool? BooleanNullableByType { get; set; }

		#endregion

        #region Selects

        [UxHint(UxHintType.Select)]
		[Display(Name="Normal list")]
		public string ForeignKeyValue { get; set; } // Foreign keys need to be mapped as strings in your view model


		[UxHint(UxHintType.Select)]
		[Display(Name = "Grouped list")]
		public string ForeignKeyValue2 { get; set; } // Foreign keys need to be mapped as strings in your view model

        #endregion


        #region Files

        public string Name { get; set; }

        [Required]
        public Attachment AttachmentOne { get; set; }

        public Attachment AttachmentTwo { get; set; }
        #endregion

    }
}