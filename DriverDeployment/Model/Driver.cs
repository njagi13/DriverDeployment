using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls.Primitives;

namespace DriverDeployment.Model
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
       public int Status { get; set; }
        public DateTime DateLastUpdated { get; set; }

        //Relationship
        public Driver()
        {
            this.Id = Guid.NewGuid();
        }
        public virtual ICollection<Leave> Leave { get; set; }
        public virtual ICollection<DriverActivity> DriverActivities { get; set; }


    }
}
