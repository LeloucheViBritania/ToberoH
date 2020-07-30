using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class DefaultService
    {
        [Key]
        public int DefaultServiceId { get; set; }

        [StringLength(70)]
        public String DafaulServiceName { get; set; }

    }
}