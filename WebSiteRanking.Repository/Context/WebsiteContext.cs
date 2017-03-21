using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebSiteRanking.Repository
{
    public partial class WebsiteContext : DbContext
    {
        public virtual DbSet<Website> Website { get; set; }
        public virtual DbSet<WebsiteVisit> WebsiteVisit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
  
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Website>(entity =>
            {
                entity.Property(e => e.Website1)
                    .IsRequired()
                    .HasColumnName("Website")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WebsiteVisit>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Website)
                    .WithMany(p => p.WebsiteVisit)
                    .HasForeignKey(d => d.WebsiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WebsiteVisit_Website");
            });
        }
    }
}