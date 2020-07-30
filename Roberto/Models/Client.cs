using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class Client
    {

        [Key]
        public int clientId { get; set; }

        [StringLength(120)]
        public string NomClient { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateEntree { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }

        public BedRoom BedRoom { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public Comment Comment { get; set;  }

        

    }
}