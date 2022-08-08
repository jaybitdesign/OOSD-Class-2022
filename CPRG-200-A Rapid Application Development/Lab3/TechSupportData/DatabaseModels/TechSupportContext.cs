using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TechSupportData.DatabaseModels
{
    public partial class TechSupportContext : DbContext
    {
        public TechSupportContext()
        {
        }

        public TechSupportContext(DbContextOptions<TechSupportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Incident> Incidents { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<Technician> Technicians { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["TechSupport"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.State).IsFixedLength();

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_States_Customers");
            });

            modelBuilder.Entity<Incident>(entity =>
            {
                entity.Property(e => e.ProductCode).IsFixedLength();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Incidents)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidents_Customers");

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.Incidents)
                    .HasForeignKey(d => d.ProductCode)
                    .HasConstraintName("FK_Incidents_Products");

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.Incidents)
                    .HasForeignKey(d => d.TechId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Incidents_Technicians");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductCode).IsFixedLength();
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductCode });

                entity.Property(e => e.ProductCode).IsFixedLength();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Registrations_Customers");

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.ProductCode)
                    .HasConstraintName("FK_Registrations_Products");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.StateCode).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
