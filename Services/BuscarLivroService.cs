
using api_biblia.Models;
using Flurl.Http;

namespace api_biblia.Services
{
    public class BuscarLivroService
    {
    
        public async Task<Livro> Buscar(string abreviatura)
        {

            string url = $"https://www.abibliadigital.com.br/api/books/{abreviatura}";
            return await url.GetJsonAsync<Livro>();

        }

    }
}

