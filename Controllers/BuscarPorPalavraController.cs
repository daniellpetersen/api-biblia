using api_biblia.Services;
using api_biblia.Services.Criar;
using Microsoft.AspNetCore.Mvc;

namespace api_biblia.Controllers
{
    [Route("[controller]")]
    public class BuscarPorPalavraController : Controller
    {
        private readonly ILogger<BuscarPorPalavraController> _logger;
        private readonly PesquisarPalavrasService _service;
        public BuscarPorPalavraController(ILogger<BuscarPorPalavraController> logger, PesquisarPalavrasService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> BuscarPorPalavra(string versao, string palavra)
        {

            var result = await _service.BuscarPorPalavra(versao,palavra);

            return result == null ? NotFound() : Ok(result);
        }
    }
}
