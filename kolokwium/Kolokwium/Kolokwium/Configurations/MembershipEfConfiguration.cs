using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium.Configurations
{
    public class MembershipEfConfiguration : IEntityTypeConfiguration<FirefighterAction>
    {
        public void Configure(EntityTypeBuilder<FirefighterAction> builder)
        {
            builder.ToTable("Membership");
            builder.HasKey(x => new { x.IdMember, x.IdTeam }).HasName("Membership_pk");

            builder.HasOne(x => x.IdFirefighterNavigation).WithMany(x => x.FirefighterActions).HasForeignKey(x => x.IdFirefighter);

            builder.HasOne(x => x.IdActionNavigation).WithMany(x => x.FirefighterActions).HasForeignKey(x => x.IdAction);




        }
    }
}
