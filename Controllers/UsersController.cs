using api_biblia.Services;
using api_biblia.Services.Criar;
using Microsoft.AspNetCore.Mvc;

namespace api_biblia.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly CriarUsuarioService _service;
        public UsersController(ILogger<UsersController> logger, CriarUsuarioService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> BuscarPorPalavra(string nome, string email, string senha, bool notificacoes)
        {

            var result = await _service.BuscarPorPalavra(nome, email, senha, notificacoes);

            return result == null ? NotFound() : Ok(result);
        }
    }

    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly BuscarUsuarioService _service;
        public UserController(ILogger<UserController> logger, BuscarUsuarioService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Buscar(string email)
        {

            var result = await _service.Buscar(email);

            return result == null ? NotFound() : Ok(result);
        }
    }

    [Route("[controller]")]
    public class UpdateTokenController : Controller
    {
        private readonly ILogger<UpdateTokenController> _logger;
        private readonly UpdateUserTokenService _service;
        public UpdateTokenController(ILogger<UpdateTokenController> logger, UpdateUserTokenService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPut]
        public async Task<IActionResult> Buscar(string email, string senha)
        {

            var result = await _service.AlterarToken(email, senha);

            return result == null ? NotFound() : Ok(result);
        }
    }

    [Route("[controller]")]
    public class UserStatusController : Controller
    {
        private readonly ILogger<UserStatusController> _logger;
        private readonly BuscarStatusUserService _service;
        public UserStatusController(ILogger<UserStatusController> logger, BuscarStatusUserService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Buscar()
        {

            var result = await _service.Buscar();

            return result == null ? NotFound() : Ok(result);
        }
    }

    [Route("[controller]")]
    public class AlterarSenhaUserController : Controller
    {
        private readonly ILogger<AlterarSenhaUserController> _logger;
        private readonly AlterarSenhaUserService _service;
        public AlterarSenhaUserController(ILogger<AlterarSenhaUserController> logger, AlterarSenhaUserService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Buscar(string email)
        {

            var result = await _service.BuscarEmail(email);

            return result == null ? NotFound() : Ok(result);
        }
    }

    [Route("[controller]")]
    public class DeletarUserController : Controller
    {
        private readonly ILogger<DeletarUserController> _logger;
        private readonly DeleteUserService _service;
        public DeletarUserController(ILogger<DeletarUserController> logger, DeleteUserService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpDelete]
        public async Task<IActionResult> Buscar(string email, string password)
        {

            var result = await _service.Buscar(email, password);

            return result == null ? NotFound() : Ok(result);
        }
    }
}
