using api_biblia.Models;
using Flurl;
using Flurl.Http;

namespace api_biblia.Services
{
    public class ExcluirUserService
    {
        public async Task<UserDelete> DeletarUser(string email, string senha)
        {

            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IlNhdCBGZWIgMDQgMjAyMyAwMzoyNDozOSBHTVQrMDAwMC42M2RkOWRhZjUyYjA1MDAwMjQ0YTgxYjMiLCJpYXQiOjE2NzU0ODEwNzl9.2rBBE1bhlx21PTDuXsQIgG0B98TeHq4HyeUfnzYUYRw";

            var UpdateUser = new UpdateUser
            {
                Senha = senha,
                Email = email,
            };

            var url = $"https://www.abibliadigital.com.br/api/users"
             .AppendPathSegments(email, senha)
            //Caso tenha que passar algo no header 
            .WithHeader("UserAgent", "UserAgentValue")
            //Caso tenha token 
            .WithOAuthBearerToken(token)
            .DeleteAsync(UpdateUser);
            return url;
        }
    }
}
