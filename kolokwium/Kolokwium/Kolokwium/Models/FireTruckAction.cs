using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class FireTruckAction
    {
        public int IdFireTruckAction { get; set; }
        public int IdFireTruck { get; set; }
        public int IdAction { get; set; }
        public DateTime AssignmentDate { get; set; }

        public virtual FireTruck IdFireTruckrNavigation { get; set; }
        public virtual Action IdActionNavigation { get; set; }
    }

}
