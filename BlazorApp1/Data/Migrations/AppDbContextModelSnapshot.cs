﻿// <auto-generated />
using System;
using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp.Data.Models.DetaliiFactura", b =>
                {
                    b.Property<int>("IdDetaliiFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetaliiFactura"));

                    b.Property<int>("IdLocatie")
                        .HasColumnType("int");

                    b.Property<decimal>("Cantitate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<string>("NumeProdus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PretUnitar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Valoare")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdDetaliiFactura", "IdLocatie");

                    b.ToTable("DetaliiFactura");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Factura", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFactura"));

                    b.Property<int>("IdLocatie")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFactura")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumarFactura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFactura", "IdLocatie");

                    b.ToTable("Facturi");
                });
#pragma warning restore 612, 618
        }
    }
}
