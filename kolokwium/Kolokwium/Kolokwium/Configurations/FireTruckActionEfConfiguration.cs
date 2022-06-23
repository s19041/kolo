using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium.Configurations
{
    public class FireTruckActionEfConfiguration : IEntityTypeConfiguration<FireTruckAction>
    {
        public void Configure(EntityTypeBuilder<FireTruckAction> builder)
        {
            builder.ToTable("FireTruck_Action");
            builder.HasKey(x =>x.IdFireTruckAction).HasName("FirefighterAction_pk");

            builder.HasOne(x => x.IdFireTruckrNavigation).WithMany(x => x.FireTruckActions).HasForeignKey(x => x.IdFireTruck);

            builder.HasOne(x => x.IdActionNavigation).WithMany(x => x.FireTruckActions).HasForeignKey(x => x.IdAction);




            builder.Property(x => x.AssignmentDate).IsRequired();
        }
    }
}
