using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class BedRoom
    {
        [Key]
        public int BedRoomId { get; set; }
        
        public int PiceBedRoom { get; set; }

        [StringLength(250)]
        public string NameBedRoom { get; set; }


        [MaxLength(500)]
        public int SizeBedRoom { get; set; }

        public bool Disponible { get; set; }

        [MaxLength(6)]
        public int NumberChild { get; set; }

        [MaxLength(6)]
        public int NumberAdult { get; set; }

        [StringLength(1000)]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [ForeignKey("ImgId")]
        public Image Ïmage { get; set; }

        public string Service { get; set; }

        public int Note { get; set; }


        [Required]
        public int Capacité_Chambre { get; set; }
        public ICollection<ServicesRoom>  servicesRooms { get; set; }

        [Required]
        public DateTime Date_Disponible { get; set; }

    }
}