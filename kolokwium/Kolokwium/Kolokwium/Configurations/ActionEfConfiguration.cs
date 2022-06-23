using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Models;

namespace Kolokwium.Configurations
{
    public class TeamEfConfiguration : IEntityTypeConfiguration<Models.Team>
    {
        public void Configure(EntityTypeBuilder<Models.Team> builder)
        {
            builder.HasKey(x => x.IdTeam).HasName("Team_pk");

            builder.Property(x => x.IdTeam).UseIdentityColumn();

            builder.Property(x => x.IdOrganization).IsRequired();
            builder.Property(x => x.TeamName).IsRequired();
            builder.Property(x => x.TeamDescription).IsRequired();
        }
    }
}
