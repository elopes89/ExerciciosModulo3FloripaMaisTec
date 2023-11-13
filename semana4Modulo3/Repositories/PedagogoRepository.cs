using LabSchool.Context;
using LabSchool.Models;

namespace LabSchool.Repositories;

public class PedagogoRepository
{
    private readonly LabSchoolContext _context;

    public PedagogoRepository(LabSchoolContext context){
        _context = context;
    }

    public List<Pedagogo> ObterPedagogos(){
        return _context.Pedagogos.ToList();
    }

    public Pedagogo ObterPedagogoPorCodigo(int codigo){
        return _context.Pedagogos.FirstOrDefault(x => x.Codigo.Equals(codigo));
    }

    public Pedagogo AtendimentoPedagogicoPedagogo(int codigo){

        var pedagogo = ObterPedagogoPorCodigo(codigo);
        
        _context.Pedagogos?.Remove(pedagogo);
        pedagogo.QtdAtendimento = pedagogo.QtdAtendimento + 1;
        _context.Pedagogos?.Update(pedagogo);
        _context.SaveChanges();
        return pedagogo;
    }

}