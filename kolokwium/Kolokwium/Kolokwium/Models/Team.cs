using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Team
    {
        public int IdTeam { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool NeedSpecialEquipment { get; set; }

        public virtual ICollection<FirefighterAction> FirefighterActions { get; set; }
        public virtual ICollection<FireTruckAction> FireTruckActions { get; set; }
    }
}
