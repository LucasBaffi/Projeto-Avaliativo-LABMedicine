using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LABMedicine.DTO
{
    public class CreatePacienteDTO
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Genero { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string? Alergias { get; set; }
        public string? CuidadosEspecificos { get; set; }
        public string ContatoEmergencia { get; set; }
        public string Convenio { get; set; }
    }
}