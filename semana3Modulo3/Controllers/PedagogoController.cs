using LabSchool.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LabSchool.Controllers;

[ApiController]
[Route("Pedagogoontroller")]
public class PedagogoController : ControllerBase{

private readonly PedagogoRepository _pedagogoRepository;

public PedagogoController(PedagogoRepository pedagogoRepository){
    _pedagogoRepository = pedagogoRepository;
}

[HttpGet("ListarPedagogos")]
public IActionResult Listar(){
    var pedagogos = _pedagogoRepository.ObterPedagogos();
    return Ok(pedagogos);
}

}