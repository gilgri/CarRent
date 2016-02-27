namespace CarRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_metadata_Location : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "Addreass", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "Addreass", c => c.String());
        }
    }
}
