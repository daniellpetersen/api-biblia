using Microsoft.AspNetCore.Mvc;
using api_biblia.Services;
using api_biblia.Exceptions;

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

        if (result is null)
        {
            throw new NotFoundException("Não foi possível encontrar o Versículo, verifique os campos digitados!");
        }
        else
        {
            return Ok(result);
        }
    }


}
