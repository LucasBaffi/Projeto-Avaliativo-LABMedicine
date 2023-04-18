using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace LABMedicine.Model
{


    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Genero { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }


    }
}