using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Models;
using Microsoft.AspNetCore.Mvc;
using LABMedicine.DTO;

namespace LABMedicine.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoControler : ControllerBase
    {
        private readonly LabmedicinebdContext _labmedicinebdContext;

        public MedicoControler(LabmedicinebdContext labmedicinebdContext)
        {
            _labmedicinebdContext = labmedicinebdContext;
        }
        [HttpPost]
        public ActionResult<CreateMedicoDTO> Post([FromBody] CreateMedicoDTO medicoDto)
        {
            if (string.IsNullOrWhiteSpace(medicoDto.NomeCompleto) ||
                   string.IsNullOrWhiteSpace(medicoDto.Genero) ||
                   medicoDto.DataNascimento == null ||
                   string.IsNullOrWhiteSpace(medicoDto.CPF) ||
                   string.IsNullOrWhiteSpace(medicoDto.Telefone))
            {
                return BadRequest("Todos os campos obrigatórios devem ser preenchidos.");
            }

            var responseCpf = _labmedicinebdContext.Medicos.Any(p => p.CPF == medicoDto.CPF);
            if (responseCpf)
            {
                return StatusCode(409, "CPF já cadastrado na base de dados");
            }
            var medico = new MedicoModel();
            {
                medico.NomeCompleto = medicoDto.NomeCompleto;
                medico.Genero = medicoDto.Genero;
                medico.DataNascimento = medicoDto.DataNascimento;
                medico.CPF = medicoDto.CPF;
                medico.Telefone = medicoDto.Telefone;
                medico.InstituicaoEnsino = medicoDto.InstituicaoEnsino;
                medico.CRM = medicoDto.CRM;
                medico.Especializacao = medicoDto.Especializacao;
            };

            _labmedicinebdContext.Medicos.Add(medico);
            _labmedicinebdContext.SaveChanges();

            return StatusCode(201, medicoDto);
        }

        [HttpPut]
        public ActionResult<UpdateMedicoDTO> Put([FromBody] UpdateMedicoDTO medicoDto)
        {
            if (string.IsNullOrWhiteSpace(medicoDto.NomeCompleto) ||
                string.IsNullOrWhiteSpace(medicoDto.Genero) ||
                medicoDto.DataNascimento == null ||
                string.IsNullOrWhiteSpace(medicoDto.CPF) ||
                string.IsNullOrWhiteSpace(medicoDto.Telefone))
            {
                return BadRequest("Todos os campos obrigatórios devem ser preenchidos.");
            }

            var medicoExistente = _labmedicinebdContext.Medicos.Where(w => w.Id == medicoDto.Id).FirstOrDefault();
            if (medicoExistente == null)
            {
                return NotFound("Medico não encontrado.");
            }

            var responseCpf = _labmedicinebdContext.Medicos.Any(p => p.CPF == medicoDto.CPF && p.Id != medicoDto.Id);
            if (responseCpf)
            {
                return StatusCode(409, "CPF já cadastrado na base de dados");
            }

            medicoExistente.NomeCompleto = medicoDto.NomeCompleto;
            medicoExistente.Genero = medicoDto.Genero;
            medicoExistente.DataNascimento = medicoDto.DataNascimento;
            medicoExistente.CPF = medicoDto.CPF;
            medicoExistente.Telefone = medicoDto.Telefone;
            medicoExistente.InstituicaoEnsino = medicoDto.InstituicaoEnsino;
            medicoExistente.Especializacao = medicoDto.Especializacao;
            medicoExistente.Estado = medicoDto.Estado;
            medicoExistente.TotalAtendimentos = medicoDto.TotalAtendimentos;



            _labmedicinebdContext.SaveChanges();

            return Ok(medicoDto);
        }

        [HttpPut("{id}/status")]
        public ActionResult UpdateStatus(int id, [FromBody] string Estado)
        {
            var medico = _labmedicinebdContext.Medicos.Find(id);

            if (medico == null)
            {
                return NotFound($"Não foi encontrado nenhum medico com o id {id}.");
            }

            if (!Enum.TryParse<EstadoSistema>(Estado, out var estado))
            {
                return BadRequest("O status informado não é válido.");
            }

            medico.Estado = estado;

            _labmedicinebdContext.SaveChanges();

            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MedicoDTO>> GetMedico([FromQuery] EstadoSistema? Estado)
        {
            IQueryable<MedicoModel> query = _labmedicinebdContext.Medicos;
            if (Estado.HasValue)
            {
                query = query.Where(p => p.Estado == Estado.Value);
            }

            var medicos = query
                .Select(p => new MedicoDTO
                {
                    Id = p.Id,
                    NomeCompleto = p.NomeCompleto,
                    Genero = p.Genero,
                    DataNascimento = p.DataNascimento,
                    CPF = p.CPF,
                    Telefone = p.Telefone,
                    InstituicaoEnsino = p.InstituicaoEnsino,
                    CRM = p.CRM,
                    Especializacao = p.Especializacao,
                    Estado = p.Estado


                })
                .ToList();

            return Ok(medicos);
        }
        [HttpGet("{id}")]
        public ActionResult<MedicoDTO> GetMedicoById(int id)
        {
            var medico = _labmedicinebdContext.Medicos.Find(id);

            if (medico == null)
            {
                return NotFound($"Não foi encontrado nenhum médico com o id {id}.");
            }

            var medicoDto = new MedicoDTO
            {
                Id = medico.Id,
                NomeCompleto = medico.NomeCompleto,
                Genero = medico.Genero,
                DataNascimento = medico.DataNascimento,
                CPF = medico.CPF,
                Telefone = medico.Telefone,
                InstituicaoEnsino = medico.InstituicaoEnsino,
                CRM = medico.CRM,
                Especializacao = medico.Especializacao,
                Estado = medico.Estado
            };

            return Ok(medicoDto);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMedico(int id)
        {
            var medico = _labmedicinebdContext.Medicos.Find(id);

            if (medico == null)
            {
                return NotFound($"Não foi encontrado nenhum médico com o id {id}.");
            }

            _labmedicinebdContext.Medicos.Remove(medico);
            _labmedicinebdContext.SaveChanges();

            return NoContent();
        }


    }
}