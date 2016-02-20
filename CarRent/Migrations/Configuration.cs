namespace CarRent.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarRent.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarRent.Models.Context context)
        {
            //  This method will be called after migrating to the latest version.
            //TODO: add here defult value to DB.
            // need to find where to call this func 

            //Location jer = new Location();
            //jer.Addreass = "jer - uri baron";
            //jer.Latitude = 31.8269986;
            //jer.Longitude = 35.2474827;

            //Branch branch = new Branch();
            //branch.Name = "jer-branch";
            //branch.Address = jer;
            //context.Branchs.AddOrUpdate(branch);

            //Location tlv = new Location();
            //tlv.Addreass = "tlv - Allenby";
            //tlv.Latitude = 32.0676462;
            //tlv.Longitude = 34.7712005;

            //Branch branch2 = new Branch();
            //branch.Name = "tlv-branch";
            //branch.Address = tlv;
            //context.Branchs.AddOrUpdate(branch2);

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
