using Microsoft.AspNetCore.Mvc;
using api_biblia.Services;

namespace api_biblia.Controllers;

[Route("[controller]")]
public class BuscarVersoesController : ControllerBase
{

    private readonly ILogger<BuscarVersoesController> _logger;
    private readonly BuscarVersoesService _service;
    public BuscarVersoesController(ILogger<BuscarVersoesController> logger, BuscarVersoesService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> BuscarVersoes()
    {

        var result = await _service.Buscar();

        return result == null ? NotFound() : Ok(result);
    }


}
