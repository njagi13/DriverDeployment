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
      
        //Relationship
        public virtual ICollection<Route> Route { get; set; }
    }
}