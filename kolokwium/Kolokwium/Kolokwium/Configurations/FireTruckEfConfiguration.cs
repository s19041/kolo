using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium.Configurations
{
    public class FireTruckEfConfiguration : IEntityTypeConfiguration<FireTruck>
    {
        public void Configure(EntityTypeBuilder<FireTruck> builder)
        {
            builder.HasKey(x => x.IdFireTruck).HasName("FireTruck_pk");

            builder.Property(x => x.IdFireTruck).UseIdentityColumn();

            builder.Property(x => x.OperationalNumber).HasMaxLength(10).IsRequired();
            builder.Property(x => x.SpecialEquipment).IsRequired();
        }
    }
}
