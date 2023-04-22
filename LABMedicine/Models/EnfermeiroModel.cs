using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Models;

namespace LABMedicine.Models
{
   public class EnfermeiroModel : Pessoa
{
    [Required]
    public string InstituicaoEnsinoFormacao { get; set; }
    
    [Required]
    public string CadastroCOFEN { get; set; }
}

}