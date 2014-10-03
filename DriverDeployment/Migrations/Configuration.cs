using System.Collections.Generic;
using System.Globalization;
using DriverDeployment.Model;

namespace DriverDeployment.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DriverDeployment.Model.DriverDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DriverDeployment.Model.DriverDatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //


            var andrew = new Driver
            {
                FirstName = "Andrew ",
                SecondName = "Peters"
            };
            var peter = new Driver
            {
                FirstName = "Peter ",
                SecondName = "Njoroge"
            };
            var kimani = new Driver
            {
                FirstName = "Kimani ",
                SecondName = "Ngunjiri"
            };
            context.Drivers.Add(andrew);
            context.Drivers.Add(peter);
            context.Drivers.Add(kimani);


            var leave1 = new Leave
            {
                TotalDays = 20,
                StartLeave = new DateTime(2013, 11, 30, 8, 00, 21),
                ResumeToWork = new DateTime(2013, 12, 8, 8, 00, 21),
                Drivers = andrew
            };
            var leave2 = new Leave
            {
                TotalDays = 10,
                StartLeave = new DateTime(2013, 11, 30, 8, 00, 21),
                ResumeToWork = new DateTime(2013, 12, 5, 8, 00, 21),
                Drivers = peter
            };
            var leave3 = new Leave
            {
                TotalDays = 10,
                StartLeave = new DateTime(2013, 11, 25, 8, 00, 21),
                ResumeToWork = new DateTime(2013, 11, 30, 8, 00, 21),
                Drivers = kimani
            };
            context.Leaves.AddOrUpdate(leave1);
            context.Leaves.AddOrUpdate(leave2);
            context.Leaves.AddOrUpdate(leave3);

            var bus1 = new Bus
            {
                BusNumber = "KBC 200P",
                Capacity = 65
            };
            var bus2 = new Bus
            {
                BusNumber = "KBC 201P",
                Capacity = 63
            };
            var bus3 = new Bus
            {
                BusNumber = "KBC 202P",
                Capacity = 65
            };
            context.Busses.Add(bus1);
            context.Busses.Add(bus2);
            context.Busses.Add(bus3);

            var route1 = new Route
            {
                RouteCode = "0001",
                RouteName = "Kampala",
                Busses = bus1
            };
            var route2 = new Route
            {
                RouteCode = "0002",
                RouteName = "Busia",
                Busses = bus2
            };

            var route3 = new Route
            {
                RouteCode = "0003",
                RouteName = "Sirare",
                Busses = bus3
            };
            context.Routes.AddOrUpdate(route1);
            context.Routes.AddOrUpdate(route2);
            context.Routes.AddOrUpdate(route3);

            //var driverTransaction1 = new DriverActivity
            //{
            //    ActivityCode = 0,
            //    DepatureDateTime = new DateTime(2000, 01, 01, 9, 45, 36),
            //    ArrivalDateTime = DateTime.Now,
            //    Driver = andrew,
            //    Route = route1
            //};
            //context.DriverActivities.AddOrUpdate(driverTransaction1);
        }
    }
}