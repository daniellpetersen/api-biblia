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
<<<<<<< HEAD
    public async Task<IActionResult> BuscarLivro()
    {

        var result = await _service.Buscar();
=======
    public async Task<IActionResult> BuscarLivro(string biblia, string livro, string capitulo)
    {

        var result = await _service.Buscar(biblia,livro,capitulo);
>>>>>>> ae9b2be73b2b1447b66d66d5451701f31261518a
        
        return result == null ? NotFound() : Ok(result);
    }


}
