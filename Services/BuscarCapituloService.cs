
using api_biblia.Models;
namespace api_biblia.Services;
using Flurl.Http;

public class BuscarCapituloService
    {
        public async Task<CapituloBiblia> Buscar(string biblia, string livro, string capitulo){

        string url = $"https://www.abibliadigital.com.br/api/verses/{biblia}/{livro}/{capitulo}";
        return await url.GetJsonAsync<CapituloBiblia>();

    }

}