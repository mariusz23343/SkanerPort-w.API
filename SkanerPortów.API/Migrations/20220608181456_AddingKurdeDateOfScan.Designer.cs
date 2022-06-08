﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkanerPortów.API;

namespace SkanerPortów.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220608181456_AddingKurdeDateOfScan")]
    partial class AddingKurdeDateOfScan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SkanerPortów.API.Entities.ScanEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ipv4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<int>("PortNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScanDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ScanEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
