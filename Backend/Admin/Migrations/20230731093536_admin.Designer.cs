﻿// <auto-generated />
using Authentication.Context;
using Authentication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Admin.Migrations
{
    [DbContext(typeof(AdminContext))]
    [Migration("20230731093536_admin")]
    partial class admin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Admin.Models.Admin", b =>
                {
                    b.Property<int>("Admin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Admin_id"));

                    b.Property<string>("Admin_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Admin_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Admin_id");

                    b.ToTable("Admins");
                });
#pragma warning restore 612, 618
        }
    }
}
