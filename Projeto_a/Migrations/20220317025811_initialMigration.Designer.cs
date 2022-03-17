﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto_a.Data;

namespace Projeto_WDProducers.Migrations
{
    [DbContext(typeof(WDProducersContext))]
    [Migration("20220317025811_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("Projeto_a.Models.Departamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Nome");

                    b.Property<string>("Sigla")
                        .HasColumnType("TEXT")
                        .HasColumnName("Sigla");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Projeto_a.Models.Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT")
                        .HasColumnName("Foto");

                    b.Property<Guid>("IdDepartamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT")
                        .HasColumnName("Nome");

                    b.Property<int>("RG")
                        .HasColumnType("INTEGER")
                        .HasColumnName("RG");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}