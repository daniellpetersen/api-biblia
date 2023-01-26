using Microsoft.AspNetCore.Mvc;
using api_biblia.Services;

namespace api_biblia.Controllers;

[Route("[controller]")]
public class BuscarCapituloController : ControllerBase
    {

    private readonly ILogger<BuscarCapituloController> _logger;
    private readonly BuscarCapituloService _service;
    public BuscarCapituloController(ILogger<BuscarCapituloController> logger, BuscarCapituloService service) 
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> BuscarLivro(string biblia, string livro, string capitulo)
    {

        var result = await _service.Buscar(biblia,livro,capitulo);
        
        return result == null ? NotFound() : Ok(result);
    }


}
