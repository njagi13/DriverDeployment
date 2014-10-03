using System;
using System.Collections.Generic;

namespace DriverDeployment.Model
{
    public class DriverActivity
    {
       
        public DriverActivity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime DepatureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int ActivityCode { get; set; }
        
        //Relationship
        public virtual Route Route { get; set; }
        public virtual Driver Driver { get; set; }
        
    }
}