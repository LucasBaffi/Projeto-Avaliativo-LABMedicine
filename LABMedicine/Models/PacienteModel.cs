using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Controllers;
using LABMedicine.Models;

using System.Text.Json.Serialization;

namespace LABMedicine.Models
{
    [Table("Paciente")]
    public class PacienteModel : Pessoa
    {

        [Column("Alergias")]
        [MaxLength(100)]
        public string? Alergias { get; set; }
        [Column("CuidadosEspecificos")]
        public string? CuidadosEspecificos { get; set; }

        [Column("ContatoEmergencia")]
        [MaxLength(100)]
        public string ContatoEmergencia { get; set; }

        [Column("Convenio")]
        public string Convenio { get; set; }

        [Column("StatusAtendimento")]
        public StatusAtendimento StatusAtendimento { get; set; }

        [Column("TotalAtendimentosRealizados")]
        public int TotalAtendimentosRealizados { get; set; }
      
        
    }
}










    

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusAtendimento
    {
        Atendido ,
        NaoAtendido ,
        EmAtendimento ,

        AguardandoAtendimento 
    }



