namespace CarRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_metadata_carType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarTypes", "Manufacturer", c => c.String(nullable: false));
            AlterColumn("dbo.CarTypes", "Model", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarTypes", "Model", c => c.String());
            AlterColumn("dbo.CarTypes", "Manufacturer", c => c.String());
        }
    }
}
