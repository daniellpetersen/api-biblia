using Microsoft.AspNetCore.Mvc;
using api_biblia.Services;



namespace api_biblia.Controllers;

[Route("[controller]")]
public class BuscarVersiculosController : ControllerBase
    {

    private readonly ILogger<BuscarVersiculosController> _logger;
    private readonly BuscarVersiculoService _service;
    public BuscarVersiculosController(ILogger<BuscarVersiculosController> logger, BuscarVersiculoService service) 
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> BuscarVersiculo(string biblia, string livro, string capitulo, string versiculo)
    {

        var result = await _service.Buscar(biblia,livro,capitulo, versiculo);
        
        return result == null ? NotFound() : Ok(result);
    }


}
