using api_biblia.Models;
using Flurl;
using Flurl.Http;

namespace api_biblia.Services.Criar
{
    public class CriarUsuarioService
    {
        public async Task<Users> BuscarPorPalavra(string nome, string email, string senha, bool notificacoes)
        {

            var result = await "https://www.abibliadigital.com.br/api/users"
                .WithHeader("Accept", "application/json")
                .AppendPathSegments()
                .AllowAnyHttpStatus()
                .PostJsonAsync(new { name = nome, email, password = senha, notifications = notificacoes})
                .ReceiveJson<Users>();

            return result;
        }
    }
}
