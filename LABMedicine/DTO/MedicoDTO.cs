using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Models;

namespace LABMedicine.DTO
{
    public class MedicoDTO
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }

        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string InstituicaoEnsino { get; set; }
        public string CRM { get; set; }
        public EspecializacaoClinica Especializacao { get; set; }
        public EstadoSistema Estado { get; set; }
    }
}