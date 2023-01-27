using Microsoft.AspNetCore.Mvc;
using api_biblia.Services;

namespace api_biblia.Controllers
{
    [Route("[controller]")]
    public class BuscarVersiculoAleatorioController : ControllerBase
    {
        private readonly ILogger<BuscarVersiculoAleatorioController> _logger;
        private readonly BuscarVersiculoAleatorioService _service;
        public BuscarVersiculoAleatorioController(ILogger<BuscarVersiculoAleatorioController> logger, BuscarVersiculoAleatorioService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarVersiculo(string versao, string abreviatura)
        {

            var result = await _service.Buscar(versao, abreviatura);

            return result == null ? NotFound() : Ok(result);



        }
    }
}
