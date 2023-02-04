using api_biblia.Models;
using Flurl;
using Flurl.Http;

namespace api_biblia.Services
{
    public class BuscarStatusUserService
    {
        public async Task<UserStats> Buscar()
        {
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IlNhdCBGZWIgMDQgMjAyMyAwMzoyNDozOSBHTVQrMDAwMC42M2RkOWRhZjUyYjA1MDAwMjQ0YTgxYjMiLCJpYXQiOjE2NzU0ODEwNzl9.2rBBE1bhlx21PTDuXsQIgG0B98TeHq4HyeUfnzYUYRw";

            var url = await $"https://www.abibliadigital.com.br/api/users/"
               .AppendPathSegments("stats")
                // Caso tenha que passar algo no header
                .WithHeader("UserAgent", "UserAgentValue")
                // Caso tenha token
                .WithOAuthBearerToken(token)
                .GetJsonAsync<UserStats>();
                 return url;

        }
    }
}
