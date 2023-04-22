using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.DTO;
using LABMedicine.Models;
using Microsoft.AspNetCore.Mvc;

namespace LABMedicine.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly LabmedicinebdContext _labmedicinebdContext;

        public PacienteController(LabmedicinebdContext labmedicinebdContext)
        {
            _labmedicinebdContext = labmedicinebdContext;
        }
        [HttpPost]
        public ActionResult<CreatePacienteDTO> Post([FromBody] CreatePacienteDTO pacienteDto)
        {
            if (string.IsNullOrWhiteSpace(pacienteDto.NomeCompleto) ||
                   string.IsNullOrWhiteSpace(pacienteDto.Genero) ||
                   pacienteDto.DataNascimento == null ||
                   string.IsNullOrWhiteSpace(pacienteDto.CPF) ||
                   string.IsNullOrWhiteSpace(pacienteDto.Telefone))
            {
                return BadRequest("Todos os campos obrigatórios devem ser preenchidos.");
            }

            var responseCpf = _labmedicinebdContext.Pacientes.Any(p => p.CPF == pacienteDto.CPF);
            if (responseCpf)
            {
                return StatusCode(409, "CPF já cadastrado na base de dados");
            }
            var paciente = new PacienteModel();
            {
                paciente.NomeCompleto = pacienteDto.NomeCompleto;
                paciente.Genero = pacienteDto.Genero;
                paciente.DataNascimento = pacienteDto.DataNascimento;
                paciente.CPF = pacienteDto.CPF;
                paciente.Telefone = pacienteDto.Telefone;
                paciente.Alergias = pacienteDto.Alergias;
                paciente.ContatoEmergencia = pacienteDto.ContatoEmergencia;
                paciente.Convenio = pacienteDto.Convenio;
            };

            // Adiciona o paciente ao banco de dados e salva as mudanças
            _labmedicinebdContext.Pacientes.Add(paciente);
            _labmedicinebdContext.SaveChangesAsync();

            return StatusCode(201, pacienteDto);

        }
        [HttpPut]
        public ActionResult<UpDatePacienteDTO> Put([FromBody] UpDatePacienteDTO pacienteDto)
        {
            if (string.IsNullOrWhiteSpace(pacienteDto.NomeCompleto) ||
                string.IsNullOrWhiteSpace(pacienteDto.Genero) ||
                pacienteDto.DataNascimento == null ||
                string.IsNullOrWhiteSpace(pacienteDto.CPF) ||
                string.IsNullOrWhiteSpace(pacienteDto.Telefone))
            {
                return BadRequest("Todos os campos obrigatórios devem ser preenchidos.");
            }

            var pacienteExistente = _labmedicinebdContext.Pacientes.Where(w => w.Id == pacienteDto.Id).FirstOrDefault();
            if (pacienteExistente == null)
            {
                return NotFound("Paciente não encontrado.");
            }

            var responseCpf = _labmedicinebdContext.Pacientes.Any(p => p.CPF == pacienteDto.CPF && p.Id != pacienteDto.Id);
            if (responseCpf)
            {
                return StatusCode(409, "CPF já cadastrado na base de dados");
            }

            pacienteExistente.NomeCompleto = pacienteDto.NomeCompleto;
            pacienteExistente.Genero = pacienteDto.Genero;
            pacienteExistente.DataNascimento = pacienteDto.DataNascimento;
            pacienteExistente.CPF = pacienteDto.CPF;
            pacienteExistente.Telefone = pacienteDto.Telefone;
            pacienteExistente.Alergias = pacienteDto.Alergias;
            pacienteExistente.ContatoEmergencia = pacienteDto.ContatoEmergencia;
            pacienteExistente.Convenio = pacienteDto.Convenio;



            _labmedicinebdContext.SaveChanges();

            return Ok(pacienteDto);
        }
        [HttpPut("{id}/status")]
        public ActionResult UpdateStatus(int id, [FromBody] string novoStatus)
        {
            var paciente = _labmedicinebdContext.Pacientes.Find(id);

            if (paciente == null)
            {
                return NotFound($"Não foi encontrado nenhum paciente com o id {id}.");
            }

            if (!Enum.TryParse<StatusAtendimento>(novoStatus, out var status))
            {
                return BadRequest("O status informado não é válido.");
            }

            paciente.StatusAtendimento = status;

            _labmedicinebdContext.SaveChanges();

            return Ok();
        }









    }
}