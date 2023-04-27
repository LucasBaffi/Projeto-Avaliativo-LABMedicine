// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using LABMedicine.Models;

// namespace LABMedicine.Data
// {
//     public static class DataSeed
//     {
//         public static void SeedData(LabmedicinebdContext context)
//         {
//             // Criação de pacientes
//             var pacientes = new List<PacienteModel>()
//         {
//             new PacienteModel()
//             {   
//                 Id = 1,
//                 NomeCompleto = "Fulano da Silva",
//                 DataNascimento = new DateTime(1990, 1, 1),
//                 Telefone = "11 99999-9999",
//                 Alergias = "Amendoim",
//                 CuidadosEspecificos = "Nenhum",
//                 ContatoEmergencia = "11 88888-8888",
//                 Convenio = "Unimed",
//                 StatusAtendimento = StatusAtendimento.NaoAtendido,
//                 TotalAtendimentosRealizados = 0
//             },
//              new PacienteModel()
//             {
//                                 Id = 2,

//         NomeCompleto = "José da Silva",
//         DataNascimento = new DateTime(1985, 3, 21),
//         Telefone = "11 97777-7777",
//         Alergias = "Penicilina",
//         CuidadosEspecificos = "Nenhum",
//         ContatoEmergencia = "11 95555-5555",
//         Convenio = "Unimed",
//         StatusAtendimento = StatusAtendimento.NaoAtendido,
//         TotalAtendimentosRealizados = 0
//     },
//     new PacienteModel()
//     {
//                         Id = 3,

//         NomeCompleto = "Maria dos Santos",
//         DataNascimento = new DateTime(1978, 7, 15),
//         Telefone = "11 96666-6666",
//         Alergias = "Frutos do mar",
//         CuidadosEspecificos = "Nenhum",
//         ContatoEmergencia = "11 94444-4444",
//         Convenio = "SulAmérica",
//         StatusAtendimento = StatusAtendimento.NaoAtendido,
//         TotalAtendimentosRealizados = 0
//     },
//     new PacienteModel()
//     {
//         Id = 4,
//         NomeCompleto = "João Batista",
//         DataNascimento = new DateTime(1980, 12, 3),
//         Telefone = "11 95555-5555",
//         Alergias = "Leite",
//         CuidadosEspecificos = "Nenhum",
//         ContatoEmergencia = "11 93333-3333",
//         Convenio = "Bradesco Saúde",
//         StatusAtendimento = StatusAtendimento.NaoAtendido,
//         TotalAtendimentosRealizados = 0
//     },
//     new PacienteModel()
//     {
//         Id = 5,
//         NomeCompleto = "Ana Paula",
//         DataNascimento = new DateTime(1992, 4, 19),
//         Telefone = "11 94444-4444",
//         Alergias = "Amendoim",
//         CuidadosEspecificos = "Nenhum",
//         ContatoEmergencia = "11 92222-2222",
//         Convenio = "Porto Seguro",
//         StatusAtendimento = StatusAtendimento.NaoAtendido,
//         TotalAtendimentosRealizados = 0
//     },
//     new PacienteModel()
//     {
//         Id = 6,
//         NomeCompleto = "Luiz Felipe",
//         DataNascimento = new DateTime(1975, 9, 8),
//         Telefone = "11 93333-3333",
//         Alergias = "Aspirina",
//         CuidadosEspecificos = "Nenhum",
//         ContatoEmergencia = "11 91111-1111",
//         Convenio = "Unimed",
//         StatusAtendimento = StatusAtendimento.NaoAtendido,
//         TotalAtendimentosRealizados = 0
//     },
//     new PacienteModel()
//     {
//         Id = 7,
//         NomeCompleto = "Juliana Santos",
//         DataNascimento = new DateTime(1988, 6, 25),
//         Telefone = "11 92222-2222",
//         Alergias = "Nenhum",
//         CuidadosEspecificos = "Hipertensa",
//         ContatoEmergencia = "11 90000-0000",
//         Convenio = "SulAmerica",
//         StatusAtendimento = StatusAtendimento.NaoAtendido,
//         TotalAtendimentosRealizados = 0

//         },
//             new PacienteModel()
//          {
//             Id = 8,
//         NomeCompleto = "joao Felipe",
//         DataNascimento = new DateTime(1975, 9, 8),
//         Telefone = "11 93333-3333",
//         Alergias = "Aspirina",
//         CuidadosEspecificos = "Nenhum",
//         ContatoEmergencia = "11 91111-1111",
//         Convenio = "Unimed",
//         StatusAtendimento = StatusAtendimento.NaoAtendido,
//         TotalAtendimentosRealizados = 0
//     },
//         new PacienteModel()
//      {
//         Id = 9,
//         NomeCompleto = "pedro Felipe",
//         DataNascimento = new DateTime(1975, 9, 8),
//         Telefone = "11 93333-3333",
//         Alergias = "Aspirina",
//         CuidadosEspecificos = "Nenhum",
//         ContatoEmergencia = "11 91111-1111",
//         Convenio = "Unimed",
//         StatusAtendimento = StatusAtendimento.NaoAtendido,
//         TotalAtendimentosRealizados = 0
//     },
//         };
//             context.Pacientes.AddRange(pacientes);
//             context.SaveChanges();

//             // Criação de enfermeiros
//             var enfermeiros = new List<EnfermeiroModel>()
//         {
//             new EnfermeiroModel()
//             {
//                 Id = 1,
//                 NomeCompleto = "Enfermeira 1",
//                 CadastroCOFEN = "123456",
//                 Telefone = "11 99999-9999"
//             },
//             new EnfermeiroModel()
//             {
//                 Id = 2,
//                 NomeCompleto = "Enfermeira 2",
//                 CadastroCOFEN = "654321",
//                 Telefone = "11 88888-8888"
//             }
//         };
//             context.Enfermeiros.AddRange(enfermeiros);
//             context.SaveChanges();

//             // Criação de médicos
//             var medicos = new List<MedicoModel>()
//         {
//             new MedicoModel()
//             {
//                 Id = 1,
//                 NomeCompleto = "Dr. Médico 1",
//                 CRM = "12345",
//                 Telefone = "11 99999-9999"
//             },
//             new MedicoModel()
//             {
//                 Id = 2,
//                 NomeCompleto = "Dr. Médico 2",
//                 CRM = "54321",
//                 Telefone = "11 88888-8888"
//             }
//         };
//             context.Medicos.AddRange(medicos);
//             context.SaveChanges();
//         }
//     }
// }