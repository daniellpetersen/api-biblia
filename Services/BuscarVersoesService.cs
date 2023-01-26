
using api_biblia.Models;
using Flurl.Http;

namespace api_biblia.Services;

public class BuscarVersoesService
{
    public async Task<List<Versoes>> Buscar()
    {

        string url = $"https://www.abibliadigital.com.br/api/versions";
        return await url.GetJsonAsync<List<Versoes>>();

    }

}

