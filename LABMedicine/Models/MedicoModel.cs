using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LABMedicine.Models;


namespace LABMedicine.Models
{
    public class MedicoModel : Pessoa
    {
        [Required]
        public string InstituicaoEnsino { get; set; }

        [Required]
        public string CRM { get; set; }

        [Required]
        public EspecializacaoClinica Especializacao { get; set; }

        public EstadoSistema Estado { get; set; }

        public int TotalAtendimentos { get; set; }
    }


    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EspecializacaoClinica
    {
        ClinicoGeral ,
        Anestesista,
        Dermatologia,
        Ginecologia,
        Neurologia,
        Pediatria,
        Psiquiatria,
        Ortopedia
    }
     [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EstadoSistema
    {
        Ativo,
        Inativo
    }




}


