using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LABMedicine.Models
{
    public class AtendimentoModel
    {
        public int Id { get; set; }
        public DateTime DataAtendimento { get; set; }


        [ForeignKey("MedicoModel")]
        public int IdMedico { get; set; }

    
        public MedicoModel MedicoModel { get; internal set; }



        [ForeignKey("PacienteModel")]
        public int IdPaciente { get; set; }
       
        public PacienteModel PacienteModel { get; internal set; }
    }
}