﻿// <auto-generated />
using System;
using ControleOficina.Servicos.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControleOficina.Servicos.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230419105721_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ControleOficina.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_criacao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("NumeroTelefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_criacao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("NumeroTelefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Peca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_criacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Peca");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.PecaServico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_criacao");

                    b.Property<Guid>("PecaId")
                        .HasColumnType("uuid");

                    b.Property<long>("Quantidade")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ServicoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PecaId");

                    b.HasIndex("ServicoId");

                    b.ToTable("PecaServico");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Servico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_criacao");

                    b.Property<DateTime?>("DataFinalizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid>("FuncionarioId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("ValorServico")
                        .HasColumnType("numeric");

                    b.Property<Guid>("VeiculoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Veiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Ano")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<Guid>("ClienteId")
                        .HasMaxLength(100)
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_criacao");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.PecaServico", b =>
                {
                    b.HasOne("ControleOficina.Domain.Entities.Peca", "Peca")
                        .WithMany("Pecas")
                        .HasForeignKey("PecaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControleOficina.Domain.Entities.Servico", "Servico")
                        .WithMany("Pecas")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Peca");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Servico", b =>
                {
                    b.HasOne("ControleOficina.Domain.Entities.Funcionario", "Funcionario")
                        .WithMany("Servicos")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControleOficina.Domain.Entities.Veiculo", "Veiculo")
                        .WithMany("Servicos")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Veiculo", b =>
                {
                    b.HasOne("ControleOficina.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Veiculos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Funcionario", b =>
                {
                    b.Navigation("Servicos");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Peca", b =>
                {
                    b.Navigation("Pecas");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Servico", b =>
                {
                    b.Navigation("Pecas");
                });

            modelBuilder.Entity("ControleOficina.Domain.Entities.Veiculo", b =>
                {
                    b.Navigation("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}