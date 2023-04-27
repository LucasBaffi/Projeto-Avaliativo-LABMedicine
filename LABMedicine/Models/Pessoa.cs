using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace LABMedicine.Models
{


    public abstract class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NomeCompleto { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]

        [DataType(DataType.Date)]
        public new DateTime DataNascimento { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Telefone { get; set; }


    }
}