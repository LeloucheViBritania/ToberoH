using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class AbImageHome
    {
        [Key]
        public int IdAbHome { get; set; }
        public string NameImgAbHome { get; set; }
    }
}