using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LABMedicine.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enfermeiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstituicaoEnsinoFormacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastroCOFEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermeiros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstituicaoEnsino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especializacao = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    TotalAtendimentos = table.Column<int>(type: "int", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alergias = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CuidadosEspecificos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContatoEmergencia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Convenio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusAtendimento = table.Column<int>(type: "int", nullable: false),
                    TotalAtendimentosRealizados = table.Column<int>(type: "int", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAtendimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atendimento_Medicos_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atendimento_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enfermeiros",
                columns: new[] { "Id", "CPF", "CadastroCOFEN", "DataNascimento", "Genero", "InstituicaoEnsinoFormacao", "NomeCompleto", "Telefone" },
                values: new object[,]
                {
                    { 1, "45678912300", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Universidade de Brasília", "Pedro Oliveira", "4567891230" },
                    { 2, "78912345600", "654321", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feminino", "Universidade de Campinas", "Juliana Santos", "7891234560" }
                });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "CPF", "CRM", "DataNascimento", "Especializacao", "Estado", "Genero", "InstituicaoEnsino", "NomeCompleto", "Telefone", "TotalAtendimentos" },
                values: new object[,]
                {
                    { 1, "12345678900", "123456", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Masculino", "Universidade Federal de Minas Gerais", "João Silva", "1234567890", 0 },
                    { 2, "98765432100", "654321", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0, "Feminino", "Universidade de São Paulo", "Maria Santos", "9876543210", 0 }
                });

            migrationBuilder.InsertData(
                table: "Paciente",
                columns: new[] { "Id", "Alergias", "CPF", "ContatoEmergencia", "Convenio", "CuidadosEspecificos", "DataNascimento", "Genero", "NomeCompleto", "StatusAtendimento", "Telefone", "TotalAtendimentosRealizados" },
                values: new object[,]
                {
                    { 1, null, "987.654.321-00", "Ana Oliveira (esposa) - (11) 99999-8888", "Amil", null, new DateTime(1990, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "José Oliveira", 2, "(11) 91234-5678", 5 },
                    { 2, "Penicilina", "123.456.789-00", "João Silva (irmão) - (11) 99999-7777", "Unimed", "Diabetes tipo 2", new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feminino", "Maria Silva", 1, "(11) 98765-4321", 0 },
                    { 3, null, "456.123.789-00", "Patrícia Ferreira (esposa) - (11) 99999-2222", "Bradesco Saúde", null, new DateTime(1975, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Carlos Ferreira", 0, "(11) 93333-3333", 3 },
                    { 4, "Frutos do mar", "333.444.555-66", "Ricardo Santos (irmão) - (11) 99999-1111", "SulAmérica", null, new DateTime(1995, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feminino", "Ana Santos", 3, "(11) 95555-5555", 1 },
                    { 11, "Penicilina", "123.456.789-10", "João Santos (irmão) - (21) 99999-7777", "Unimed", "Nenhum", new DateTime(1985, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feminino", "Maria Santos", 1, "(21) 98765-4321", 0 },
                    { 12, "Nenhum", "789.123.456-90", "Luciana Souza (esposa) - (31) 99999-6666", "Bradesco Saúde", "Nenhum", new DateTime(1977, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Felipe Souza", 1, "(31) 91234-5678", 0 },
                    { 13, null, "246.135.790-23", "Maria Silva (mãe) - (41) 99999-5555", "SulAmérica", null, new DateTime(1998, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feminino", "Ana Silva", 3, "(41) 98765-4321", 2 },
                    { 14, "Aspirina", "345.678.901-12", "Aline Vieira (filha) - (51) 99999-4444", "Amil", "Nenhum", new DateTime(1955, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Luiz Vieira", 1, "(51) 91234-5678", 0 },
                    { 15, "Frutos do mar", "567.890.123-45", "davi samuca (irmao) - (11) 98765-4321", "Amil", "Uso de medicação controlada", new DateTime(1995, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feminino", "Carla Oliveira", 1, "(11) 98765-4321", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_IdMedico",
                table: "Atendimento",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_IdPaciente",
                table: "Atendimento",
                column: "IdPaciente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Enfermeiros");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
