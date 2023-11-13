using LabSchool.Models;
using LabSchool.Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using LabSchool.Dtos;
using LabSchool.Extensions;

namespace LabSchool.Controllers;

[ApiController]
[Route("AlunoController")]
public class AlunoController : ControllerBase
{
    private readonly AlunoRepository _alunoRepository;

    private readonly IMapper _mapper;

    public AlunoController(AlunoRepository alunoRepository, IMapper mapper)
    {
        _alunoRepository = alunoRepository;
        _mapper = mapper;
    }

    [HttpGet("/ListarAlunos")]
    public IActionResult Listar()
    {
        var alunos = _alunoRepository.ObterAlunos();
        return Ok(alunos);
    }

    [HttpGet]
    [Route("/BuscaPorCodigo/{codigo}")]
    public IActionResult ObterAluno(int codigo)
    {
        var aluno = _alunoRepository.ObterPorId(codigo);

        if (aluno == null)
            return NotFound("Código não encontrado!");

        return Ok(aluno);
    }

    [HttpGet]
    [Route("/ConsultaPorMatricula")]
    public IActionResult BuscarSituacao([FromQuery] string situacao)
    {
        var alunos = _alunoRepository.Filtrar(situacao);
        return Ok(alunos);
    }

    [HttpPost]
    [Route("/CadastrarAluno")]
    public IActionResult Criar([FromBody] AlunoCreateDto createDto)
    {
        
        var validaSituacao = createDto.Situacao.ValidarSituacao();
        var verficaCpf = _alunoRepository.ExistCpf(createDto.CPF);
        if (verficaCpf ==  false)
        {
            return StatusCode(409, "Cpf já cadastrado!");
        }
        if (validaSituacao == false)
        {
            return BadRequest("Tipo de matrícula inválida");
        }
        else
        {
            var aluno = _mapper.Map<Aluno>(createDto);
            _alunoRepository.Criar(aluno);
            var alunoSaidaDto = _mapper.Map<AlunoSaidaDto>(aluno);

            return CreatedAtAction(
                nameof(AlunoController.Listar),
                new { id = aluno.Codigo },
                alunoSaidaDto
            );
        }
    }

    [HttpDelete("/DeletarAluno/{codigo}")]
    public IActionResult Delete(int codigo)
    {
        var aluno = _alunoRepository.ObterPorId(codigo);

        if (aluno == null)
        {
            return NotFound("Código de Aluno não Encontrado");
        }
        _alunoRepository.Excluir(codigo);
        return NoContent();
    }

    [HttpPatch]
    [Route("/EditarSituacao/{codigo}")]
    public IActionResult AtualizarSituacaoAluno(int codigo, [FromForm] AlunoSituacaoDto dto)
    {
        var validaSituacao = dto.SituacaoDto.ToUpper().ValidarSituacao();
                if (validaSituacao == false)
        {
            return BadRequest("Tipo de matrícula inválida");
        }
        else
        {
            var aluno = _alunoRepository?.AtualizarSituacao(codigo, dto);
            return Ok(aluno);
        }
    }
}
