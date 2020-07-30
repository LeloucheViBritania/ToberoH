using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        [Required, Display(Name = "Sender Name")]
        public string SenderName { get; set; }
        [Required, Display(Name = "Sender Email"), EmailAddress]
        public string SenderEmail { get; set; }
        [Required]
        public string Message { get; set; }
    }
}