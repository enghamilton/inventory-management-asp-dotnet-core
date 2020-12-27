using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace InventoryManagement.Models
{
    public partial class InventoryContext : DbContext
    {
        /*
        public InventoryContext()
        {
        }
        */
        
        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                // Maps to the AspNetUsers table
                entity.ToTable("products");

                // Primary key
                entity.HasKey(e => new {e.pid})
                    .HasName("pid");

                entity.Property(e => e.pid)
                    .HasColumnType("int");

                entity.Property(e => e.username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnType("text");

                entity.Property(e => e.phone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.price)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnType("text");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
