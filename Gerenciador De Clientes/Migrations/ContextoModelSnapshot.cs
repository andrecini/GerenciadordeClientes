﻿// <auto-generated />
using System;
using Gerenciador_De_Clientes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gerenciador_De_Clientes.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Gerenciador_De_Clientes.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<int>("Bloqueado")
                        .HasColumnType("int")
                        .HasColumnName("Bloqueado");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("CpfCnpj");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DataCadastro");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<int>("Genero")
                        .HasColumnType("int")
                        .HasColumnName("Genero");

                    b.Property<string>("IncricaoEstadual")
                        .HasColumnType("longtext")
                        .HasColumnName("IncricaoEstadual");

                    b.Property<int>("Isento")
                        .HasColumnType("int")
                        .HasColumnName("Isento");

                    b.Property<string>("NomeRazaoSocial")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NomeRazaoSocial");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Telefone");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
