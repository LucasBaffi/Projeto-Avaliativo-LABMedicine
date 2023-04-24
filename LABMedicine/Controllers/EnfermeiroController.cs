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
    public class EnfermeiroController : ControllerBase
    {
        private readonly LabmedicinebdContext _labmedicinebdContext;

        public EnfermeiroController(LabmedicinebdContext labmedicinebdContext)
        {
            _labmedicinebdContext = labmedicinebdContext;
        }

        [HttpPost]
        public ActionResult<CreateUpdateEnfermeiro> Post([FromBody] CreateUpdateEnfermeiro enfermeiroDto)
        {
            if (string.IsNullOrWhiteSpace(enfermeiroDto.NomeCompleto) ||
                   string.IsNullOrWhiteSpace(enfermeiroDto.Genero) ||
                   enfermeiroDto.DataNascimento == null ||
                   string.IsNullOrWhiteSpace(enfermeiroDto.CPF) ||
                   string.IsNullOrWhiteSpace(enfermeiroDto.Telefone))
            {
                return BadRequest("Todos os campos obrigatórios devem ser preenchidos.");
            }

            var responseCpf = _labmedicinebdContext.Enfermeiros.Any(p => p.CPF == enfermeiroDto.CPF);
            if (responseCpf)
            {
                return StatusCode(409, "CPF já cadastrado na base de dados");
            }
            var enfermeiro = new EnfermeiroModel();
            {
                enfermeiro.NomeCompleto = enfermeiroDto.NomeCompleto;
                enfermeiro.Genero = enfermeiroDto.Genero;
                enfermeiro.DataNascimento = enfermeiroDto.DataNascimento;
                enfermeiro.CPF = enfermeiroDto.CPF;
                enfermeiro.Telefone = enfermeiroDto.Telefone;
                enfermeiro.CadastroCOFEN = enfermeiroDto.CadastroCOFEN;
                enfermeiro.InstituicaoEnsinoFormacao = enfermeiroDto.InstituicaoEnsinoFormacao;

            };

            _labmedicinebdContext.Enfermeiros.Add(enfermeiro);
            _labmedicinebdContext.SaveChanges();

            return StatusCode(201, enfermeiroDto);
        }

        [HttpPut]
        public ActionResult<CreateUpdateEnfermeiro> Put([FromBody] CreateUpdateEnfermeiro enfermeiroDto)
        {
            if (string.IsNullOrWhiteSpace(enfermeiroDto.NomeCompleto) ||
                string.IsNullOrWhiteSpace(enfermeiroDto.Genero) ||
                enfermeiroDto.DataNascimento == null ||
                string.IsNullOrWhiteSpace(enfermeiroDto.CPF) ||
                string.IsNullOrWhiteSpace(enfermeiroDto.Telefone))
            {
                return BadRequest("Todos os campos obrigatórios devem ser preenchidos.");
            }

            var enfermeiroExistente = _labmedicinebdContext.Enfermeiros.Where(w => w.Id == enfermeiroDto.Id).FirstOrDefault();
            if (enfermeiroExistente == null)
            {
                return NotFound("Enfermeiro não encontrado.");
            }

            var responseCpf = _labmedicinebdContext.Enfermeiros.Any(p => p.CPF == enfermeiroDto.CPF && p.Id != enfermeiroDto.Id);
            if (responseCpf)
            {
                return StatusCode(409, "CPF já cadastrado na base de dados");
            }

            enfermeiroExistente.NomeCompleto = enfermeiroDto.NomeCompleto;
            enfermeiroExistente.Genero = enfermeiroDto.Genero;
            enfermeiroExistente.DataNascimento = enfermeiroDto.DataNascimento;
            enfermeiroExistente.CPF = enfermeiroDto.CPF;
            enfermeiroExistente.Telefone = enfermeiroDto.Telefone;
            enfermeiroExistente.CadastroCOFEN = enfermeiroDto.CadastroCOFEN;
            enfermeiroExistente.InstituicaoEnsinoFormacao = enfermeiroDto.InstituicaoEnsinoFormacao;

            _labmedicinebdContext.SaveChanges();

            return Ok(enfermeiroDto);
        }
        [HttpGet]
        public ActionResult<IEnumerable<EnfermeiroModel>> Get()
        {
            var enfermeiros = _labmedicinebdContext.Enfermeiros.ToList();
            if (enfermeiros.Count == 0)
            {
                return NotFound("Nenhum enfermeiro encontrado.");
            }
            return Ok(enfermeiros);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<EnfermeiroModel>> GetById(int id)
        {
            var enfermeiro = _labmedicinebdContext.Enfermeiros.Find(id);
            if (enfermeiro == null)
            {
                return NotFound("Nenhum enfermeiro encontrado.");
            }
            return Ok(enfermeiro);
        }
        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            var enfermeiro = _labmedicinebdContext.Enfermeiros.Find(id);
            if (enfermeiro == null)
            {
                return NotFound($"Não foi encontrado nenhum médico com o id {id}.");
            }

            _labmedicinebdContext.Enfermeiros.Remove(enfermeiro);
            _labmedicinebdContext.SaveChanges();

            return NoContent();
        }




    }
}