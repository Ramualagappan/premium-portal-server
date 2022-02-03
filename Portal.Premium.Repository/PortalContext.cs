using Microsoft.EntityFrameworkCore;
using Portal.EntityModel;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Premium.Repository
{
    public class PortalContext : DbContext
    {
        public PortalContext(DbContextOptions<PortalContext> options)
            : base(options)
        {
        }

        public DbSet<OccupationDetails> OccupationDetails { get; set; }
        public DbSet<OccupationRating> OccupationRating { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OccupationDetails>(entity =>
            {
                entity.ToTable("Occupation");
                entity.HasKey(k => k.Id);
                entity.Property(e => e.Id)
                   .ValueGeneratedOnAdd();
                entity.Property(t => t.Occupation).HasMaxLength(100);
                
            }); 
            modelBuilder.Entity<OccupationRating>(entity =>
            {
                entity.ToTable("OccupationRating");
                entity.HasKey(k => k.RatingId);
                entity.Property(e => e.RatingId)
                    .HasColumnName("RatingId")
                    .ValueGeneratedOnAdd();

                entity.HasMany(t => t.lstOccupationDetails).WithOne(e => e.OccupationRating).HasForeignKey(n => n.RatingId);
            });
        }
    }
}
