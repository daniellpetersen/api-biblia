using Microsoft.AspNetCore.Mvc;
using api_biblia.Services;

namespace api_biblia.Controllers;

[Route("[controller]")]
public class BuscarLivrosController : ControllerBase
    {

    private readonly ILogger<BuscarLivrosController> _logger;
    private readonly BuscarLivrosService _service;
    public BuscarLivrosController(ILogger<BuscarLivrosController> logger, BuscarLivrosService service) 
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> BuscarLivro()
    {

        var result = await _service.Buscar();
       
        return result == null ? NotFound() : Ok(result);
    }


}
