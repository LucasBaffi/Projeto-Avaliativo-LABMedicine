﻿// <auto-generated />
using System;
using LABMedicine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LABMedicine.Migrations
{
    [DbContext(typeof(LabmedicinebdContext))]
    partial class LabmedicinebdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LABMedicine.Models.AtendimentoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMedico");

                    b.HasIndex("IdPaciente");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("LABMedicine.Models.EnfermeiroModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CadastroCOFEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituicaoEnsinoFormacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enfermeiros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "45678912300",
                            CadastroCOFEN = "123456",
                            DataNascimento = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Masculino",
                            InstituicaoEnsinoFormacao = "Universidade de Brasília",
                            NomeCompleto = "Pedro Oliveira",
                            Telefone = "4567891230"
                        },
                        new
                        {
                            Id = 2,
                            CPF = "78912345600",
                            CadastroCOFEN = "654321",
                            DataNascimento = new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Feminino",
                            InstituicaoEnsinoFormacao = "Universidade de Campinas",
                            NomeCompleto = "Juliana Santos",
                            Telefone = "7891234560"
                        });
                });

            modelBuilder.Entity("LABMedicine.Models.MedicoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Especializacao")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituicaoEnsino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalAtendimentos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medicos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "12345678900",
                            CRM = "123456",
                            DataNascimento = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Especializacao = 0,
                            Estado = 0,
                            Genero = "Masculino",
                            InstituicaoEnsino = "Universidade Federal de Minas Gerais",
                            NomeCompleto = "João Silva",
                            Telefone = "1234567890",
                            TotalAtendimentos = 0
                        },
                        new
                        {
                            Id = 2,
                            CPF = "98765432100",
                            CRM = "654321",
                            DataNascimento = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Especializacao = 3,
                            Estado = 0,
                            Genero = "Feminino",
                            InstituicaoEnsino = "Universidade de São Paulo",
                            NomeCompleto = "Maria Santos",
                            Telefone = "9876543210",
                            TotalAtendimentos = 0
                        });
                });

            modelBuilder.Entity("LABMedicine.Models.PacienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alergias")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Alergias");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContatoEmergencia")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ContatoEmergencia");

                    b.Property<string>("Convenio")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Convenio");

                    b.Property<string>("CuidadosEspecificos")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CuidadosEspecificos");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusAtendimento")
                        .HasColumnType("int")
                        .HasColumnName("StatusAtendimento");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalAtendimentosRealizados")
                        .HasColumnType("int")
                        .HasColumnName("TotalAtendimentosRealizados");

                    b.HasKey("Id");

                    b.ToTable("Paciente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "987.654.321-00",
                            ContatoEmergencia = "Ana Oliveira (esposa) - (11) 99999-8888",
                            Convenio = "Amil",
                            DataNascimento = new DateTime(1990, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Masculino",
                            NomeCompleto = "José Oliveira",
                            StatusAtendimento = 2,
                            Telefone = "(11) 91234-5678",
                            TotalAtendimentosRealizados = 5
                        },
                        new
                        {
                            Id = 2,
                            Alergias = "Penicilina",
                            CPF = "123.456.789-00",
                            ContatoEmergencia = "João Silva (irmão) - (11) 99999-7777",
                            Convenio = "Unimed",
                            CuidadosEspecificos = "Diabetes tipo 2",
                            DataNascimento = new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Feminino",
                            NomeCompleto = "Maria Silva",
                            StatusAtendimento = 1,
                            Telefone = "(11) 98765-4321",
                            TotalAtendimentosRealizados = 0
                        },
                        new
                        {
                            Id = 3,
                            CPF = "456.123.789-00",
                            ContatoEmergencia = "Patrícia Ferreira (esposa) - (11) 99999-2222",
                            Convenio = "Bradesco Saúde",
                            DataNascimento = new DateTime(1975, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Masculino",
                            NomeCompleto = "Carlos Ferreira",
                            StatusAtendimento = 0,
                            Telefone = "(11) 93333-3333",
                            TotalAtendimentosRealizados = 3
                        },
                        new
                        {
                            Id = 4,
                            Alergias = "Frutos do mar",
                            CPF = "333.444.555-66",
                            ContatoEmergencia = "Ricardo Santos (irmão) - (11) 99999-1111",
                            Convenio = "SulAmérica",
                            DataNascimento = new DateTime(1995, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Feminino",
                            NomeCompleto = "Ana Santos",
                            StatusAtendimento = 3,
                            Telefone = "(11) 95555-5555",
                            TotalAtendimentosRealizados = 1
                        },
                        new
                        {
                            Id = 11,
                            Alergias = "Penicilina",
                            CPF = "123.456.789-10",
                            ContatoEmergencia = "João Santos (irmão) - (21) 99999-7777",
                            Convenio = "Unimed",
                            CuidadosEspecificos = "Nenhum",
                            DataNascimento = new DateTime(1985, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Feminino",
                            NomeCompleto = "Maria Santos",
                            StatusAtendimento = 1,
                            Telefone = "(21) 98765-4321",
                            TotalAtendimentosRealizados = 0
                        },
                        new
                        {
                            Id = 12,
                            Alergias = "Nenhum",
                            CPF = "789.123.456-90",
                            ContatoEmergencia = "Luciana Souza (esposa) - (31) 99999-6666",
                            Convenio = "Bradesco Saúde",
                            CuidadosEspecificos = "Nenhum",
                            DataNascimento = new DateTime(1977, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Masculino",
                            NomeCompleto = "Felipe Souza",
                            StatusAtendimento = 1,
                            Telefone = "(31) 91234-5678",
                            TotalAtendimentosRealizados = 0
                        },
                        new
                        {
                            Id = 13,
                            CPF = "246.135.790-23",
                            ContatoEmergencia = "Maria Silva (mãe) - (41) 99999-5555",
                            Convenio = "SulAmérica",
                            DataNascimento = new DateTime(1998, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Feminino",
                            NomeCompleto = "Ana Silva",
                            StatusAtendimento = 3,
                            Telefone = "(41) 98765-4321",
                            TotalAtendimentosRealizados = 2
                        },
                        new
                        {
                            Id = 14,
                            Alergias = "Aspirina",
                            CPF = "345.678.901-12",
                            ContatoEmergencia = "Aline Vieira (filha) - (51) 99999-4444",
                            Convenio = "Amil",
                            CuidadosEspecificos = "Nenhum",
                            DataNascimento = new DateTime(1955, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Masculino",
                            NomeCompleto = "Luiz Vieira",
                            StatusAtendimento = 1,
                            Telefone = "(51) 91234-5678",
                            TotalAtendimentosRealizados = 0
                        },
                        new
                        {
                            Id = 15,
                            Alergias = "Frutos do mar",
                            CPF = "567.890.123-45",
                            ContatoEmergencia = "davi samuca (irmao) - (11) 98765-4321",
                            Convenio = "Amil",
                            CuidadosEspecificos = "Uso de medicação controlada",
                            DataNascimento = new DateTime(1995, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Feminino",
                            NomeCompleto = "Carla Oliveira",
                            StatusAtendimento = 1,
                            Telefone = "(11) 98765-4321",
                            TotalAtendimentosRealizados = 0
                        });
                });

            modelBuilder.Entity("LABMedicine.Models.AtendimentoModel", b =>
                {
                    b.HasOne("LABMedicine.Models.MedicoModel", "MedicoModel")
                        .WithMany()
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LABMedicine.Models.PacienteModel", "PacienteModel")
                        .WithMany()
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicoModel");

                    b.Navigation("PacienteModel");
                });
#pragma warning restore 612, 618
        }
    }
}
