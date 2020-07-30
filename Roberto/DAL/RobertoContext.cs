using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Roberto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roberto.DAL
{
    public class RobertoContext : DbContext
    {

        public DbSet<Image> Images { get; set;  }
        public DbSet<AbImageHome> AbImageHomes { get ; set ; }

        public DbSet<Service> Services { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<ServicesRoom> ServicesRooms { get; set; }
        public DbSet<BedRoom> BedRooms { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Activity> Activities { get; set; }


       public  DbSet<Contact> Contacts { get; set; }

        public DbSet<DefaultService> DefautServices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=Roberto;Integrated Security=True"));
        }
    }
}