﻿// <auto-generated />
using System;
using CentroComercial.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CentroComercial.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231018194510_MigrationMTO")]
    partial class MigrationMTO
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CentroComercial.Shared.Entities.CComercial", b =>
                {
                    b.Property<int>("IdCentroComercial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCentroComercial"));

                    b.Property<string>("capacidadMaxima")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horarioApertura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horarioCierre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreCentroComercial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tiendas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCentroComercial");

                    b.ToTable("Centrocomerciales");
                });

            modelBuilder.Entity("CentroComercial.Shared.Entities.Calendario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaActual")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Calendario");
                });

            modelBuilder.Entity("CentroComercial.Shared.Entities.Notificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Notificaciones");
                });

            modelBuilder.Entity("CentroComercial.Shared.Entities.Tienda", b =>
                {
                    b.Property<int>("IdTienda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTienda"));

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horarioApertura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horarioCierre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreTienda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTienda");

                    b.ToTable("Tiendas");
                });
#pragma warning restore 612, 618
        }
    }
}
