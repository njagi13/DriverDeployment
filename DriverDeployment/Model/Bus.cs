using System;
using System.Collections.Generic;

namespace DriverDeployment.Model
{
    public class Bus
    {  public Bus()
        {
            Id =Guid.NewGuid(); 
        }

        public Guid Id { get; set; }
        public string BusNumber { get; set; }
        public int Capacity { get; set; }
        public int Status { get; set; }
        public DateTime DateLastUpdated { get; set; }
      
        //Relationship
        public virtual ICollection<Route> Route { get; set; }
    }
}