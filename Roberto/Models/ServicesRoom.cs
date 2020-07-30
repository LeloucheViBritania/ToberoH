using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Roberto.Models
{
    public class ServicesRoom
    {
        [Key]
        public int ServiceRoomId { get; set; }

        public string ServiceListName { get; set; }
    }
}