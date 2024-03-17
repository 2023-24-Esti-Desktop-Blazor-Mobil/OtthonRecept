using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace BackEnd.Context
{
    public class ContextEgy :DbContext
    {

        public DbSet<Szemely> Szemelyek { get; set; }
        public DbSet<Cikk> Cikks { get; set; }
        public DbSet<Kepzettseg> Kepzettsegek { get; set; }

        public ContextEgy(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kepzettseg>()
                .HasMany(el => el.Szemelyek)
                .WithOne(s => s.Kepzettseg)
                .HasForeignKey(s => s.KepzettsegId)
                .IsRequired(false);

            modelBuilder.Entity<Szemely>()
                .HasMany(el => el.Cikks)
                .WithOne(s => s.Szemely)
                .HasForeignKey(s => s.FeltoltoId)
                .IsRequired(false);

            modelBuilder.Entity<Measurements>()
                .HasMany(el => el.Ingredients)
                .WithOne(s => s.Measurements)
                .HasForeignKey(s => s.MeasurementsId)
                .IsRequired(false);


        }
    }
}
