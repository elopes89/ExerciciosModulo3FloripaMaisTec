namespace LabSchool.Models;

public class Aluno : Pessoa {

    public  int QtdAtendimento {get; set;}
    private string _situacao;
    public string Situacao
    {
        get { return _situacao?.ToUpper(); }
        set { _situacao = value; }
    }
    
    public float Nota { get; set; }

}