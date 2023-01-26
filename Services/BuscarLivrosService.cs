
using api_biblia.Models;
using Flurl.Http;

namespace api_biblia.Services;

public class BuscarLivrosService
    {
<<<<<<< HEAD
        public async Task<List<Livros>> Buscar(){
=======
        public async Task<LivrosBiblia> Buscar(string biblia, string livro, string capitulo){

        string url = $"https://www.abibliadigital.com.br/api/verses/{biblia}/{livro}/{capitulo}";
        return await url.GetJsonAsync<LivrosBiblia>();
>>>>>>> ae9b2be73b2b1447b66d66d5451701f31261518a

        string url = $"https://www.abibliadigital.com.br/api/books";
        return await url.GetJsonAsync<List<Livros>>();

    }

}