using Microsoft.AspNetCore.Mvc;
using api_biblia.Services;



namespace api_biblia.Controllers;

[Route("[controller]")]
public class BuscarLivroController : ControllerBase
    {

    private readonly ILogger<BuscarLivroController> _logger;
    private readonly BuscarLivroService _service;
    public BuscarLivroController(ILogger<BuscarLivroController> logger, BuscarLivroService service) 
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> BuscarVersiculo(string abreviatura)
    {

        var result = await _service.Buscar(abreviatura);
        
        return result == null ? NotFound() : Ok(result);
    }


}
