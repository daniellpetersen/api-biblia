
using api_biblia.Models;
using Flurl;
using Flurl.Http;

namespace api_biblia.Services;

public class BuscarUsuarioService
{
    private readonly IConfiguration _configuration;
    public BuscarUsuarioService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public async Task<User> Buscar(string email)
    {

        var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IldlZCBGZWIgMDggMjAyMyAwMTo1NToyMiBHTVQrMDAwMC42M2UyODcwZDhmNjI2OTAwMjJiMWQ5MmIiLCJpYXQiOjE2NzU4MjEzMjJ9.gz6rB1WHq_Iq4TNax3TD40BmD8YVPb-vg7QkOxDw9Kk";

        var url = await $"https://www.abibliadigital.com.br/api/users/{email}"
           .AppendPathSegments()
            // Caso tenha que passar algo no header
            .WithHeader("UserAgent", "UserAgentValue")
            // Caso tenha token
            .WithOAuthBearerToken(token)
            .GetJsonAsync<User>();
             return url;

    }

}
