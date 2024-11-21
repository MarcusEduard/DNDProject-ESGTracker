﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(ESGContext))]
    [Migration("20241120142034_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Edata", b =>
                {
                    b.Property<int>("Environmentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CrudeFuel")
                        .HasColumnType("REAL");

                    b.Property<double>("GasFuel")
                        .HasColumnType("REAL");

                    b.Property<double>("PurchElec")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalEnergy")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("Environmentid");

                    b.ToTable("Envi");
                });
#pragma warning restore 612, 618
        }
    }
}
