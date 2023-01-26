
using api_biblia.Models;
using Flurl.Http;

namespace api_biblia.Services;

public class BuscarLivrosService
    {

        public async Task<List<Livros>> Buscar(){

        string url = $"https://www.abibliadigital.com.br/api/books";
        return await url.GetJsonAsync<List<Livros>>();

    }

}