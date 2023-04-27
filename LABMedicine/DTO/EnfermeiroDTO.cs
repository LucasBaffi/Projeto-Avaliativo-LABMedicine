using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Models;

namespace LABMedicine.DTO
{
    public class EnfermeiroDTO
    {
         public int Id { get; set; }
        public string NomeCompleto { get; set; }     
       
        public string CPF { get; set; }
        public string Telefone { get; set; }
    
         public string CadastroCOFEN { get; set; }
    }
}