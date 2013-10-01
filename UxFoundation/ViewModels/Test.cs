using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.ViewModels
{
    public class Test
    {
        public Test()
        {
            AttachmentOne = new Attachment();
            AttachmentTwo = new Attachment();

        }
        
        [Required]
        public Attachment AttachmentOne { get; set; }


        public Attachment AttachmentTwo { get; set; }
        
        
        public string Name { get; set; }
        public Address Address { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
    }
}