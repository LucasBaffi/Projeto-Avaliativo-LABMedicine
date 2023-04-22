using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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
}

public enum EspecializacaoClinica
{
    ClinicoGeral,
    Anestesista,
    Dermatologia,
    Ginecologia,
    Neurologia,
    Pediatria,
    Psiquiatria,
    Ortopedia
}

public enum EstadoSistema
{
    Ativo,
    Inativo
}

public class AtendimentoMedico
{
    public int Id { get; set; }
    public DateTime DataHora { get; set; }

    public int IdMedico { get; set; }
    public MedicoModel Medico { get; set; }

    public int IdPaciente { get; set; }
    public PacienteModel Paciente { get; set; }

}



