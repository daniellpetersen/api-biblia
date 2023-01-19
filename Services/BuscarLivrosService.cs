
using api_biblia.Models;
namespace api_biblia.Services;
using Flurl.Http;

public class BuscarLivrosService
    {
        public async Task<LivrosBiblia> Buscar(string biblia, string livro, string capitulo, string versiculo){

        string url = $"https://www.abibliadigital.com.br/api/verses/{biblia}/{livro}/{capitulo}/{versiculo}";
        return await url.GetJsonAsync<LivrosBiblia>();


    }

}
