using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Models;

namespace LABMedicine.DTO
{
    public class PacienteDTO
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }

        public string Genero { get; set; }


        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string? Alergias { get; set; }
        public string? CuidadosEspecificos { get; set; }
        public string ContatoEmergencia { get; set; }
        public string Convenio { get; set; }
         public StatusAtendimento StatusAtendimento { get; set; }
    }

   
}
