namespace LabSchool.Dtos;
using LabSchool.Models;

public class AlunoCreateDto
{

    public string? Nome { get; set; }
    public string? Telefone { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public string? CPF { get; set; }

    public string? Situacao { get; set; }

    public float Nota { get; set; }


}