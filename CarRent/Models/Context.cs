using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }

        public DbSet<Location> Locations { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Branch> Branchs { get; set; }

    }
}