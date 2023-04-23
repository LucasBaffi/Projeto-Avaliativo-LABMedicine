using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABMedicine.DTO
{
    public class CreateUpdateEnfermeiro
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string CadastroCOFEN { get; set; }
        public string InstituicaoEnsinoFormacao { get; set; }
    }
}