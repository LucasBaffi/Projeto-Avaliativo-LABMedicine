using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Models;
using Microsoft.AspNetCore.Mvc;

namespace LABMedicine.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtendimentoController : ControllerBase
    {
        private readonly LabmedicinebdContext _labmedicinebdContext;

        public AtendimentoController(LabmedicinebdContext labmedicinebdContext)
        {
            _labmedicinebdContext = labmedicinebdContext;
        }
        [HttpPut]
        public ActionResult<AtendimentoModel> RealizarAtendimento(int IdPaciente, int IdMedico)
        {
            if (IdPaciente <= 0 || IdMedico <= 0  )
            {
                return BadRequest("Os parâmetros IdPaciente e IdMedico são obrigatórios e devem ser maiores que zero.");
            }


            var paciente = _labmedicinebdContext.Pacientes.Find(IdPaciente);
            var medico = _labmedicinebdContext.Medicos.Find(IdMedico);

            if (paciente == null || medico == null)
            {
                return NotFound();
            }


            // Incrementa os atributos de atendimento do paciente e médico envolvidos
            paciente.TotalAtendimentosRealizados++;
            medico.TotalAtendimentos++;

           
            {
           // Altera o status de atendimento do paciente para "Atendido"
            paciente.StatusAtendimento = StatusAtendimento.Atendido;
}  

            var atendimento = new AtendimentoModel
            {

                MedicoModel = medico,
                PacienteModel = paciente,
                DataAtendimento = DateTime.Now
            };

            _labmedicinebdContext.Atendimento.Add(atendimento);
            _labmedicinebdContext.SaveChangesAsync();

            return CreatedAtAction(nameof(RealizarAtendimento), new { id = atendimento.Id }, atendimento);
        }
    }
}
