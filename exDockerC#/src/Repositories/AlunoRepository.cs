using LabSchool.Context;
using LabSchool.Dtos;
using LabSchool.Models;

namespace LabSchool.Repositories;

public class AlunoRepository
{
    private readonly LabSchoolContext _context;

    public AlunoRepository(LabSchoolContext context)
    {
        _context = context;
    }

    public List<Aluno> ObterAlunos()
    {
        return _context.Alunos.ToList();
    }

  
    public Aluno? ObterPorId(int id)
    {
        return _context.Alunos.FirstOrDefault(x => x.Codigo.Equals(id));
    }

    public void Criar(Aluno aluno)
    {
        _context.Alunos.Add(aluno);
        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var aluno = ObterPorId(id);
        if (aluno != null)
        {
            _context?.Alunos?.Remove(aluno);
            _context?.SaveChanges();
        }
    }
  
    
    public Aluno AtendimentoPedagogicoAluno(int idAluno)
    {
        var aluno = ObterPorId(idAluno);
        _context.Alunos?.Remove(aluno);
        _context.Alunos?.Update(aluno);
        _context.SaveChanges();
        return aluno;
    }


}
