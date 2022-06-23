using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium.Configurations
{
    public class FirefighterEfConfiguration : IEntityTypeConfiguration<Firefighter>
    {
        public void Configure(EntityTypeBuilder<Firefighter> builder)
        {
            builder.HasKey(x => x.IdFirefighter).HasName("Firefighter_pk");

            builder.Property(x => x.IdFirefighter).UseIdentityColumn();

            builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
        }
    }
}
