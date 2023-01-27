using api_biblia.Models;
namespace api_biblia.Services;
using Flurl.Http;


public class BuscarVersiculoService
{
        public async Task<VersiculosBiblia> Buscar(string biblia, string livro, string capitulo, string versiculo)
    {
        string url = $"https://www.abibliadigital.com.br/api/verses/{biblia}/{livro}/{capitulo}/{versiculo}";
        return await url.GetJsonAsync<VersiculosBiblia>();
    }
}