using api_biblia.Models;
namespace api_biblia.Services;
using Flurl.Http;

    public class BuscarVersiculoAleatorioService
    {
        public async Task<VersiculosBiblia> Buscar(string versao, string abreviatura)
        {
            string url = $"https://www.abibliadigital.com.br/api/verses/{versao}/{abreviatura}/random";
            return await url.GetJsonAsync<VersiculosBiblia>();
        }
    }
