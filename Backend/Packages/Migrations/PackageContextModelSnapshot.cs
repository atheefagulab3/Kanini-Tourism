﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PackageProj.Context;

#nullable disable

namespace Tourism.Migrations
{
    [DbContext(typeof(PackageContext))]
    partial class PackageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PackageProj.Models.Itinerary", b =>
                {
                    b.Property<int>("itinerary_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("itinerary_id"));

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("day")
                        .HasColumnType("int");

                    b.Property<string>("details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("package_id")
                        .HasColumnType("int");

                    b.Property<string>("spots")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("itinerary_id");

                    b.ToTable("itinerary");
                });

            modelBuilder.Entity("PackageProj.Models.Location", b =>
                {
                    b.Property<int>("location_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("location_id"));

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("location_id");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("PackageProj.Models.Packages", b =>
                {
                    b.Property<int>("package_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("package_id"));

                    b.Property<int>("budget")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("location_id")
                        .HasColumnType("int");

                    b.Property<string>("package_duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("package_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("spots_nearby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("package_id");

                    b.ToTable("packages");
                });
#pragma warning restore 612, 618
        }
    }
}
