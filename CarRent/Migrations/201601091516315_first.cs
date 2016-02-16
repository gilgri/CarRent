namespace CarRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kilometrage = c.Int(nullable: false),
                        Image = c.String(),
                        IsRentable = c.Boolean(nullable: false),
                        Number = c.String(),
                        Branch_Id = c.Int(),
                        CarType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.Branch_Id)
                .ForeignKey("dbo.CarTypes", t => t.CarType_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.CarType_Id);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Addreass = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Manufacturer = c.String(),
                        Model = c.String(),
                        DailyCost = c.Int(nullable: false),
                        DelayDailyCost = c.Int(nullable: false),
                        GearBox = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        ActualEnd = c.DateTime(nullable: false),
                        Car_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Car_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Alias = c.String(nullable: false),
                        Birthday = c.DateTime(),
                        Sex = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Image = c.String(),
                        Part = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Rents", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.Cars", "CarType_Id", "dbo.CarTypes");
            DropForeignKey("dbo.Cars", "Branch_Id", "dbo.Branches");
            DropForeignKey("dbo.Branches", "Address_Id", "dbo.Locations");
            DropIndex("dbo.Rents", new[] { "User_Id" });
            DropIndex("dbo.Rents", new[] { "Car_Id" });
            DropIndex("dbo.Branches", new[] { "Address_Id" });
            DropIndex("dbo.Cars", new[] { "CarType_Id" });
            DropIndex("dbo.Cars", new[] { "Branch_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Rents");
            DropTable("dbo.CarTypes");
            DropTable("dbo.Locations");
            DropTable("dbo.Branches");
            DropTable("dbo.Cars");
        }
    }
}
