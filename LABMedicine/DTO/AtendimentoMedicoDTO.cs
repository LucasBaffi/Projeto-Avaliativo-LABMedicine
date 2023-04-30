using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Models;

namespace LABMedicine.DTO
{
    public class AtendimentoMedicoDTO
    {
           public MedicoModel Medico { get; set; }
       
        public string NomeCompletoMedico => Medico?.NomeCompleto;
    }
}