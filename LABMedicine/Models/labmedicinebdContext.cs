using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Controllers;
using LABMedicine.Models;
using Microsoft.EntityFrameworkCore;
using LABMedicine.DTO;

namespace LABMedicine.Models
{
    public class LabmedicinebdContext : DbContext
    {
        public LabmedicinebdContext(DbContextOptions<LabmedicinebdContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            Builder.Entity<PacienteModel>().HasData(

                      new PacienteModel
                      {
                          Id = 1,
                          NomeCompleto = "José Oliveira",
                          Genero = "Masculino",
                          DataNascimento = new DateTime(1990, 7, 8),
                          CPF = "987.654.321-00",
                          Telefone = "(11) 91234-5678",
                          Alergias = null,
                          CuidadosEspecificos = null,
                          ContatoEmergencia = "Ana Oliveira (esposa) - (11) 99999-8888",
                          Convenio = "Amil",
                          StatusAtendimento = StatusAtendimento.EmAtendimento,
                          TotalAtendimentosRealizados = 5
                      },
new PacienteModel
{
    Id = 2,
    NomeCompleto = "Maria Silva",
    Genero = "Feminino",
    DataNascimento = new DateTime(1985, 3, 15),
    CPF = "123.456.789-00",
    Telefone = "(11) 98765-4321",
    Alergias = "Penicilina",
    CuidadosEspecificos = "Diabetes tipo 2",
    ContatoEmergencia = "João Silva (irmão) - (11) 99999-7777",
    Convenio = "Unimed",
    StatusAtendimento = StatusAtendimento.NaoAtendido,
    TotalAtendimentosRealizados = 0
},
new PacienteModel
{
    Id = 3,
    NomeCompleto = "Carlos Ferreira",
    Genero = "Masculino",
    DataNascimento = new DateTime(1975, 11, 24),
    CPF = "456.123.789-00",
    Telefone = "(11) 93333-3333",
    Alergias = null,
    CuidadosEspecificos = null,
    ContatoEmergencia = "Patrícia Ferreira (esposa) - (11) 99999-2222",
    Convenio = "Bradesco Saúde",
    StatusAtendimento = StatusAtendimento.Atendido,
    TotalAtendimentosRealizados = 3
},
new PacienteModel
{
    Id = 4,
    NomeCompleto = "Ana Santos",
    Genero = "Feminino",
    DataNascimento = new DateTime(1995, 6, 2),
    CPF = "333.444.555-66",
    Telefone = "(11) 95555-5555",
    Alergias = "Frutos do mar",
    CuidadosEspecificos = null,
    ContatoEmergencia = "Ricardo Santos (irmão) - (11) 99999-1111",
    Convenio = "SulAmérica",
    StatusAtendimento = StatusAtendimento.AguardandoAtendimento,
    TotalAtendimentosRealizados = 1
}, 
new PacienteModel
{
    Id = 11,
    NomeCompleto = "Maria Santos",
    Genero = "Feminino",
    DataNascimento = new DateTime(1985, 4, 15),
    CPF = "123.456.789-10",
    Telefone = "(21) 98765-4321",
    Alergias = "Penicilina",
    CuidadosEspecificos = "Nenhum",
    ContatoEmergencia = "João Santos (irmão) - (21) 99999-7777",
    Convenio = "Unimed",
    StatusAtendimento = StatusAtendimento.NaoAtendido,
    TotalAtendimentosRealizados = 0
},
new PacienteModel
{
    Id = 12,
    NomeCompleto = "Felipe Souza",
    Genero = "Masculino",
    DataNascimento = new DateTime(1977, 11, 22),
    CPF = "789.123.456-90",
    Telefone = "(31) 91234-5678",
    Alergias = "Nenhum",
    CuidadosEspecificos = "Nenhum",
    ContatoEmergencia = "Luciana Souza (esposa) - (31) 99999-6666",
    Convenio = "Bradesco Saúde",
    StatusAtendimento = StatusAtendimento.NaoAtendido,
    TotalAtendimentosRealizados = 0
},
new PacienteModel
{
    Id = 13,
    NomeCompleto = "Ana Silva",
    Genero = "Feminino",
    DataNascimento = new DateTime(1998, 6, 7),
    CPF = "246.135.790-23",
    Telefone = "(41) 98765-4321",
    Alergias = null,
    CuidadosEspecificos = null,
    ContatoEmergencia = "Maria Silva (mãe) - (41) 99999-5555",
    Convenio = "SulAmérica",
    StatusAtendimento = StatusAtendimento.AguardandoAtendimento,
    TotalAtendimentosRealizados = 2
},
new PacienteModel
{
    Id = 14,
    NomeCompleto = "Luiz Vieira",
    Genero = "Masculino",
    DataNascimento = new DateTime(1955, 9, 12),
    CPF = "345.678.901-12",
    Telefone = "(51) 91234-5678",
    Alergias = "Aspirina",
    CuidadosEspecificos = "Nenhum",
    ContatoEmergencia = "Aline Vieira (filha) - (51) 99999-4444",
    Convenio = "Amil",
    StatusAtendimento = StatusAtendimento.NaoAtendido,
    TotalAtendimentosRealizados = 0
},
new PacienteModel
{
    Id = 15,
    NomeCompleto = "Carla Oliveira",
    Genero = "Feminino",
    DataNascimento = new DateTime(1995, 1, 25),
    CPF = "567.890.123-45",
    Telefone = "(11) 98765-4321",
    Alergias = "Frutos do mar",
    CuidadosEspecificos = "Uso de medicação controlada",
    ContatoEmergencia = "davi samuca (irmao) - (11) 98765-4321",
     Convenio = "Amil",
    StatusAtendimento = StatusAtendimento.NaoAtendido,
    TotalAtendimentosRealizados = 0,
}

            );
            Builder.Entity<MedicoModel>().HasData(

               new MedicoModel
               {
                   Id = 1,
                   NomeCompleto = "João Silva",
                   Genero = "Masculino",
                   DataNascimento = new DateTime(1980, 1, 1),
                   CPF = "12345678900",
                   Telefone = "1234567890",
                   InstituicaoEnsino = "Universidade Federal de Minas Gerais",
                   CRM = "123456",
                   Especializacao = EspecializacaoClinica.ClinicoGeral,
                   Estado = EstadoSistema.Ativo,
                   TotalAtendimentos = 0
               },
                new MedicoModel
                {
                    Id = 2,
                    NomeCompleto = "Maria Santos",
                    Genero = "Feminino",
                    DataNascimento = new DateTime(1985, 1, 1),
                    CPF = "98765432100",
                    Telefone = "9876543210",
                    InstituicaoEnsino = "Universidade de São Paulo",
                    CRM = "654321",
                    Especializacao = EspecializacaoClinica.Ginecologia,
                    Estado = EstadoSistema.Ativo,
                    TotalAtendimentos = 0
                }
            );
            Builder.Entity<EnfermeiroModel>().HasData(
              new EnfermeiroModel
              {
                  Id = 1,
                  NomeCompleto = "Pedro Oliveira",
                  Genero = "Masculino",
                  DataNascimento = new DateTime(1990, 1, 1),
                  CPF = "45678912300",
                  Telefone = "4567891230",
                  InstituicaoEnsinoFormacao = "Universidade de Brasília",
                  CadastroCOFEN = "123456"
              },
                new EnfermeiroModel
                {
                    Id = 2,
                    NomeCompleto = "Juliana Santos",
                    Genero = "Feminino",
                    DataNascimento = new DateTime(1995, 1, 1),
                    CPF = "78912345600",
                    Telefone = "7891234560",
                    InstituicaoEnsinoFormacao = "Universidade de Campinas",
                    CadastroCOFEN = "654321"
                }

            );


        }

        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<MedicoModel> Medicos { get; set; }
        public DbSet<EnfermeiroModel> Enfermeiros { get; set; }
        public DbSet<AtendimentoModel> Atendimento { get; set; }


    }
}