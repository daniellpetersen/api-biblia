using api_biblia.Models;
using Flurl;
using Flurl.Http;

namespace api_biblia.Services
{
    public class BuscarStatusUserService
    {
        public async Task<UserStats> Buscar()
        {
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IlN1biBGZWIgMDUgMjAyMyAxODoyMDoxNyBHTVQrMDAwMC5lbmcuZGFuaWVscGV0ZXJzZW5AZ21haWwuY29tIiwiaWF0IjoxNjc1NjIxMjE3fQ.q6VMeKY3xVhExYjtnKBbOVVWrKa_7j2JCVYqTngs6K8";

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
