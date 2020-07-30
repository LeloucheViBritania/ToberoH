using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class Image
    {
        [Key]
        public int ImgId { get; set;  }

        [StringLength(100)]
        public string NameImg { get; set; }

    }
}