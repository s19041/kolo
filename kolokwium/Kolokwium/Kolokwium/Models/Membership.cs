using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Membership
    {
        public int IdMember { get; set; }
        public int IdTeam { get; set; }
        public DateTime MembershipDate { get;set;}

        public virtual Firefighter IdFirefighterNavigation { get; set; }
        public virtual Action IdActionNavigation { get; set; }
    }
}
