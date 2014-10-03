namespace DriverDeployment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buses", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Routes", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Drivers", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drivers", "Status");
            DropColumn("dbo.Routes", "Status");
            DropColumn("dbo.Buses", "Status");
        }
    }
}
