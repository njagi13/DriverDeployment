using System;
using System.Collections.Generic;

namespace DriverDeployment.Model
{
    public class Route
    {

        public Guid Id { get; set; }
        public string RouteName { get; set; }
        public string RouteCode { get; set; }
        public int Status { get; set; }
        public DateTime DateLastUpdated { get; set; }

        public Route()
        {
            Id = Guid.NewGuid();
        }
        //Relationship
      
        public virtual Bus Busses { get; set; }
        public virtual ICollection< DriverActivity>DriverActivities { get; set; } 


    }
}