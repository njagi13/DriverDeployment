namespace DriverDeployment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datelastUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buses", "DateLastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Routes", "DateLastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.DriverActivities", "DateLastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Drivers", "DateLastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Leaves", "DateLastUpdated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Leaves", "DateLastUpdated");
            DropColumn("dbo.Drivers", "DateLastUpdated");
            DropColumn("dbo.DriverActivities", "DateLastUpdated");
            DropColumn("dbo.Routes", "DateLastUpdated");
            DropColumn("dbo.Buses", "DateLastUpdated");
        }
    }
}
