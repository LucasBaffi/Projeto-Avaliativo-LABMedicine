using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Controllers;

namespace LABMedicine.Models
{
    [Table("Paciente")]
    public class Paciente : Pessoa
    {

        
        public string ContatoEmergencia { get; set; }
        public List<string> Alergias { get; set; }
        public List<string> CuidadosEspecificos { get; set; }
        public string Convenio { get; set; }
        public StatusAtendimento StatusAtendimento { get; set; }
        public int TotalAtendimentosRealizados { get; set; }
    }

    public enum StatusAtendimento
    {
        AguardandoAtendimento,
        EmAtendimento,
        Atendido,
        NaoAtendido
    }

}