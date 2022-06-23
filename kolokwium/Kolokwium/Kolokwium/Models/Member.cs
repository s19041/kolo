using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Member
    {
        public int IdMember { get; set; }
        public int IdOrganization { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public bool SpecialEquipment { get; set; }

        public virtual ICollection<FireTruckAction> FireTruckActions { get; set; }
    }
}
