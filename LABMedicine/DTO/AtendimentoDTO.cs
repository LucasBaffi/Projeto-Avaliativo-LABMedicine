using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Models;

namespace LABMedicine.DTO
{
    public class AtendimentoDTO
        
    { public int IdMedico { get; set; }
        public int IdPaciente { get; set; }

         public PacienteModel Paciente { get; set; }
        public MedicoModel Medico { get; set; }
      
     
    }
}

