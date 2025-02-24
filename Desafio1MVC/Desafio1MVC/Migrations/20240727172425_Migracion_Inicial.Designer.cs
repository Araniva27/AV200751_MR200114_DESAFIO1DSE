﻿// <auto-generated />
using Desafio1MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Desafio1MVC.Migrations
{
    [DbContext(typeof(InventarioDbContext))]
    [Migration("20240727172425_Migracion_Inicial")]
    partial class Migracion_Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Desafio1MVC.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Electrónica"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Ropa"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Alimentos"
                        });
                });

            modelBuilder.Entity("Desafio1MVC.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Nombre = "Smartphone",
                            Precio = 299.99m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 2,
                            Nombre = "Camisa",
                            Precio = 19.99m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 3,
                            Nombre = "Pan",
                            Precio = 1.99m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 1,
                            Nombre = "Laptop",
                            Precio = 799.99m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 2,
                            Nombre = "Zapatos",
                            Precio = 49.99m,
                            Stock = 150
                        });
                });

            modelBuilder.Entity("Desafio1MVC.Models.Producto", b =>
                {
                    b.HasOne("Desafio1MVC.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Desafio1MVC.Models.Categoria", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
