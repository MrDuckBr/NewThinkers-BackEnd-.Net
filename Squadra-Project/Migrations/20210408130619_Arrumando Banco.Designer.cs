﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Squadra_Project.Context;

namespace Squadra_Project.Migrations
{
    [DbContext(typeof(LocalDbContext))]
    [Migration("20210408130619_Arrumando Banco")]
    partial class ArrumandoBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Squadra_Project.Entities.Carro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("ano")
                        .HasColumnType("integer");

                    b.Property<string>("cor")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<int>("valor")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("carro");
                });
#pragma warning restore 612, 618
        }
    }
}
