﻿// <auto-generated />
using EjemploMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EjemploMVC.Migrations
{
    [DbContext(typeof(EjemploMVCContext))]
    partial class EjemploMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EjemploMVC.Models.Videos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FechaEstreno");

                    b.Property<string>("Genero");

                    b.Property<decimal>("Precio");

                    b.Property<string>("Titulo");

                    b.HasKey("ID");

                    b.ToTable("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}
