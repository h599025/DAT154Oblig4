using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleaningSystem
{
    public partial class dat154Context : DbContext
    {
        public dat154Context()
        {
        }

        public dat154Context(DbContextOptions<dat154Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:dat154assignment4-2024.database.windows.net,1433;Initial Catalog=DAT154Assignment4;Persist Security Info=False;User ID=h599025;Password=vwXL62yx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("booking");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Checkindate)
                    .HasColumnType("date")
                    .HasColumnName("checkindate");

                entity.Property(e => e.Checkoutdate)
                    .HasColumnType("date")
                    .HasColumnName("checkoutdate");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Roomnr).HasColumnName("roomnr");

                entity.HasOne(d => d.RoomnrNavigation)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.Roomnr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__booking__roomnr__2C3393D0");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("customer");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.Roomnr);

                entity.ToTable("room");

                entity.Property(e => e.Roomnr)
                    .ValueGeneratedNever()
                    .HasColumnName("roomnr");

                entity.Property(e => e.Beds).HasColumnName("beds");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Roomnr);

                entity.ToTable("Service");

                entity.Property(e => e.Roomnr)
                    .ValueGeneratedNever()
                    .HasColumnName("roomnr");

                entity.Property(e => e.Checkedin).HasColumnName("checkedin");

                entity.Property(e => e.Cleaning)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cleaning");

                entity.Property(e => e.Maintenance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("maintenance");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Service1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.RoomnrNavigation)
                    .WithOne(p => p.Service)
                    .HasForeignKey<Service>(d => d.Roomnr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Service__roomnr__2B3F6F97");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
