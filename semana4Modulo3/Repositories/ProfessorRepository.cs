using LabSchool.Context;
using LabSchool.Models;

namespace LabSchool.Repositories;



public class ProfessorRepository {
    
    private readonly LabSchoolContext _context;

    public ProfessorRepository(LabSchoolContext context){
        _context = context;
    }

    public List<Professor> ObterProfessores(){
        return _context.Professores.ToList();
    }
}