using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;




namespace DriverDeployment.Model
{
    public class DriverDatabaseContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverActivity> DriverActivities { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Bus> Busses { get; set; }
    }
}
