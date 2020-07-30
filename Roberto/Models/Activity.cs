using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(250)]
        public string  ImageActivity { get; set; }

        [StringLength(1000)]
        [DataType(DataType.Text)]
        public string CommentOnActivity { get; set; }

        [DataType(DataType.Text)]
        [StringLength(90)]
        public string TypeActivity { get; set; }

        [DataType(DataType.Text)]
        [StringLength(100)]
        public string NameActivity { get; set; }
    }
}