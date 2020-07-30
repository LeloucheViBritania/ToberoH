using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class Blog
    {

        [Key]
        public int BlogId { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        [StringLength(300)]
        public  string Videos { get; set; }

        [StringLength(1500)]
        [DataType(DataType.Text)]
        public  string CommmentPhotoos { get; set; }


         [StringLength(1500)]
        [DataType(DataType.Text)]
        public  string CommentVideos { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string TypeEvent { get; set;  }

        [DataType(DataType.Date)]
        public DateTime DatePost { get; set; }

    }
}