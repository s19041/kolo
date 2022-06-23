using Kolokwium.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class FirefighterContext : DbContext
    {
        public FirefighterContext()
        {

        }
        public FirefighterContext(DbContextOptions<FirefighterContext> options) : base(options)
        {

        }
        public virtual DbSet<Firefighter> Firefighter { get; set; }
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<FirefighterAction> FirefighterAction { get; set; }
        public virtual DbSet<FireTruck> FireTruck { get; set; }
        public virtual DbSet<FireTruckAction> FireTruckAction { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActionEfConfiguration());
            modelBuilder.ApplyConfiguration(new FirefighterEfConfiguration());
            modelBuilder.ApplyConfiguration(new FirefighterActionEfConfiguration());
            modelBuilder.ApplyConfiguration(new FireTruckEfConfiguration());
            modelBuilder.ApplyConfiguration(new FireTruckActionEfConfiguration());

        }
    }
}
