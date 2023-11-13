using LabSchool.Models;

namespace LabSchool.Dtos;

public class AlunoSaidaDto : Pessoa{

    
    public string? Situacao { get; set; }

    public int QtdAtendimento { get; set; }

    public float Nota { get; set; }



}