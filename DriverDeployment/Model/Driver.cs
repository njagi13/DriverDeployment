using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DriverDeployment.Model
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        //Relationship
        public Driver()
        {
            this.Id = Guid.NewGuid();
        }
        public virtual ICollection<Leave> Leave { get; set; }
        public virtual ICollection<DriverActivity> DriverActivities { get; set; }


    }
}
