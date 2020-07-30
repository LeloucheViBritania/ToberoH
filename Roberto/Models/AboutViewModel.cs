using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roberto.Models
{
    public class AboutViewModel
    {
        public AboutUs AboutUs { get; set; }


        public Image Images { get; set; }

        public List<Activity> Activities { get; set; }
    }
}