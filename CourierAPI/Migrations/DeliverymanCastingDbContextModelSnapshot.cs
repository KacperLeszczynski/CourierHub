﻿// <auto-generated />
using System;
using CourierAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourierAPI.Migrations
{
    [DbContext(typeof(DeliverymanCastingDbContext))]
    partial class DeliverymanCastingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourierAPI.Data.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CourierAPI.Data.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("EndLocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishedDeliveryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PickedUpTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StartLocationId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EndLocationId");

                    b.HasIndex("StartLocationId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("CourierAPI.Data.Inquiry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("DimX")
                        .HasColumnType("float");

                    b.Property<double>("DimY")
                        .HasColumnType("float");

                    b.Property<double>("DimZ")
                        .HasColumnType("float");

                    b.Property<int?>("EndLocationId")
                        .HasColumnType("int");

                    b.Property<bool>("HightPriority")
                        .HasColumnType("bit");

                    b.Property<int>("InquiryStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StartLocationId")
                        .HasColumnType("int");

                    b.Property<bool>("WeekendDelivery")
                        .HasColumnType("bit");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EndLocationId");

                    b.HasIndex("StartLocationId");

                    b.ToTable("Inquiries");
                });

            modelBuilder.Entity("CourierAPI.Data.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("CourierAPI.Data.Delivery", b =>
                {
                    b.HasOne("CourierAPI.Data.Client", "Client")
                        .WithMany("Deliveries")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourierAPI.Data.Location", "EndLocation")
                        .WithMany()
                        .HasForeignKey("EndLocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CourierAPI.Data.Location", "StartLocation")
                        .WithMany()
                        .HasForeignKey("StartLocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("EndLocation");

                    b.Navigation("StartLocation");
                });

            modelBuilder.Entity("CourierAPI.Data.Inquiry", b =>
                {
                    b.HasOne("CourierAPI.Data.Location", "EndLocation")
                        .WithMany()
                        .HasForeignKey("EndLocationId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("CourierAPI.Data.Location", "StartLocation")
                        .WithMany()
                        .HasForeignKey("StartLocationId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("EndLocation");

                    b.Navigation("StartLocation");
                });

            modelBuilder.Entity("CourierAPI.Data.Client", b =>
                {
                    b.Navigation("Deliveries");
                });
#pragma warning restore 612, 618
        }
    }
}
