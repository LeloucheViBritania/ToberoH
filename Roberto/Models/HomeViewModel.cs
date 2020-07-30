using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class HomeViewModel
    {
        public List<AbImageHome> AbImageHomes { get; set; }
        public List<Image> Images { get; set; }

        public AboutUs AboutUs { get; set; }

        public BedRoom BedRoomFirst { get; set; }
        public BedRoom BedRoomSecond { get; set; }
        public List<Service> Services { get; set; }
        
        public List<ServicesRoom> servicesRooms { get; set; }

        public List<Client> Clients { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }

        public List<Activity> Activities { get; set; } 




    }
}