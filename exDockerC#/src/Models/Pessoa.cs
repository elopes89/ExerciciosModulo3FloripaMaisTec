using System.ComponentModel.DataAnnotations;
namespace LabSchool.Models;

public abstract class Pessoa
{

    public int Codigo { get; set; }
    public string? Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }
}