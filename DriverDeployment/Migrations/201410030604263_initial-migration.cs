namespace DriverDeployment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BusNumber = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RouteName = c.String(),
                        RouteCode = c.String(),
                        Busses_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.Busses_Id)
                .Index(t => t.Busses_Id);
            
            CreateTable(
                "dbo.DriverActivities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DepatureDateTime = c.DateTime(nullable: false),
                        ArrivalDateTime = c.DateTime(nullable: false),
                        ActivityCode = c.Int(nullable: false),
                        Driver_Id = c.Guid(),
                        Route_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.Driver_Id)
                .ForeignKey("dbo.Routes", t => t.Route_Id)
                .Index(t => t.Driver_Id)
                .Index(t => t.Route_Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        SecondName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TotalDays = c.Int(nullable: false),
                        StartLeave = c.DateTime(nullable: false),
                        ResumeToWork = c.DateTime(nullable: false),
                        Drivers_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.Drivers_Id)
                .Index(t => t.Drivers_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DriverActivities", "Route_Id", "dbo.Routes");
            DropForeignKey("dbo.Leaves", "Drivers_Id", "dbo.Drivers");
            DropForeignKey("dbo.DriverActivities", "Driver_Id", "dbo.Drivers");
            DropForeignKey("dbo.Routes", "Busses_Id", "dbo.Buses");
            DropIndex("dbo.Leaves", new[] { "Drivers_Id" });
            DropIndex("dbo.DriverActivities", new[] { "Route_Id" });
            DropIndex("dbo.DriverActivities", new[] { "Driver_Id" });
            DropIndex("dbo.Routes", new[] { "Busses_Id" });
            DropTable("dbo.Leaves");
            DropTable("dbo.Drivers");
            DropTable("dbo.DriverActivities");
            DropTable("dbo.Routes");
            DropTable("dbo.Buses");
        }
    }
}
