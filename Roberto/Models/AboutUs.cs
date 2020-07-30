using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class AboutUs
    {
        [Key]
        public int AbputUs { get; set; }

        [StringLength(1300)]
        [DataType(DataType.Text)]
        public string AboutHome { get; set; }

        [StringLength(50)]
        public string AboutManagerName { get; set; }

        [StringLength(150)]
        public string ImageManager { get; set; }

        
        [DataType(DataType.Text)]
        [StringLength(1500)]
        public string AboutOnManager { get; set;  }

        [DataType(DataType.Text)]
        [StringLength(500)]
        public string SignatureManager { get; set; }

        [MaxLength(50)]
        public int YearManager { get; set; }


    }
}