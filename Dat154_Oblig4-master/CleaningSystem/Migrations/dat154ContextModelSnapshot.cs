﻿// <auto-generated />
using System;
using CleaningSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleaningSystem.Migrations
{
    [DbContext(typeof(dat154Context))]
    partial class dat154ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CleaningSystem.Booking", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Checkindate")
                        .HasColumnType("date")
                        .HasColumnName("checkindate");

                    b.Property<DateTime>("Checkoutdate")
                        .HasColumnType("date")
                        .HasColumnName("checkoutdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<int>("Roomnr")
                        .HasColumnType("int")
                        .HasColumnName("roomnr");

                    b.HasKey("Id");

                    b.HasIndex("Roomnr");

                    b.ToTable("booking", (string)null);
                });

            modelBuilder.Entity("CleaningSystem.Customer", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.HasKey("Email");

                    b.ToTable("customer", (string)null);
                });

            modelBuilder.Entity("CleaningSystem.Room", b =>
                {
                    b.Property<int>("Roomnr")
                        .HasColumnType("int")
                        .HasColumnName("roomnr");

                    b.Property<int>("Beds")
                        .HasColumnType("int")
                        .HasColumnName("beds");

                    b.Property<int?>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<int>("Size")
                        .HasColumnType("int")
                        .HasColumnName("size");

                    b.HasKey("Roomnr");

                    b.ToTable("room", (string)null);
                });

            modelBuilder.Entity("CleaningSystem.Service", b =>
                {
                    b.Property<int>("Roomnr")
                        .HasColumnType("int")
                        .HasColumnName("roomnr");

                    b.Property<bool>("Checkedin")
                        .HasColumnType("bit")
                        .HasColumnName("checkedin");

                    b.Property<string>("Cleaning")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("cleaning");

                    b.Property<string>("Maintenance")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("maintenance");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("note");

                    b.Property<string>("Service1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("service");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("status");

                    b.HasKey("Roomnr");

                    b.ToTable("Service", (string)null);
                });

            modelBuilder.Entity("CleaningSystem.Booking", b =>
                {
                    b.HasOne("CleaningSystem.Room", "RoomnrNavigation")
                        .WithMany("Bookings")
                        .HasForeignKey("Roomnr")
                        .IsRequired()
                        .HasConstraintName("FK__booking__roomnr__2C3393D0");

                    b.Navigation("RoomnrNavigation");
                });

            modelBuilder.Entity("CleaningSystem.Service", b =>
                {
                    b.HasOne("CleaningSystem.Room", "RoomnrNavigation")
                        .WithOne("Service")
                        .HasForeignKey("CleaningSystem.Service", "Roomnr")
                        .IsRequired()
                        .HasConstraintName("FK__Service__roomnr__2B3F6F97");

                    b.Navigation("RoomnrNavigation");
                });

            modelBuilder.Entity("CleaningSystem.Room", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Service")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}