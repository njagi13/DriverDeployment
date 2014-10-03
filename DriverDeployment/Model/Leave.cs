using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DriverDeployment.Model
{
    public class Leave
    {
        public Leave()
        {
            Id = Guid.NewGuid();
        }
       
        public Guid Id { get; set; }
        public int TotalDays { get; set; }
        public DateTime StartLeave { get; set; }
        public DateTime ResumeToWork { get; set; }

        
        //Relationship
        public virtual Driver Drivers { get; set; }

    }
}