using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }


        [Required]
        [StringLength(20)]
        [DataType(DataType.Text)]
        public string ServiceName { get; set; }

        [Required]
        [StringLength(200)]
        public string ServiceICon { get; set; }


    }
}