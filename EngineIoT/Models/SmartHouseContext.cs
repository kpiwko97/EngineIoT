using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngineIoT.Models
{
    public partial class SmartHouseContext : DbContext
    {
        public SmartHouseContext(DbContextOptions<SmartHouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EspWroom> EspWroom { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EspWroom>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Temperature).HasColumnType("decimal(4, 2)");
            });
        }
    }
}
