﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcClients.Data;

namespace MvcClients.Migrations
{
    [DbContext(typeof(MvcClientsContext))]
    [Migration("20200608072040_Ville")]
    partial class Ville
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MvcClients.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adresse")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Civilite")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("CodePostale")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Mail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nom")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Pays")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Prenom")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telephone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Ville")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
