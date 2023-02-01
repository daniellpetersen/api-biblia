using api_biblia.Models;
using Flurl;
using Flurl.Http;

namespace api_biblia.Services.Criar
{
    public class PesquisarPalavrasService
    {
        public async Task<PesquisarPalavra> BuscarPorPalavra(string versao, string palavra)
        {
           

            var result = await "https://www.abibliadigital.com.br/api/verses/"
                .AppendPathSegments("search")
                .PostJsonAsync(new { version = versao, search = palavra })
                .ReceiveJson<PesquisarPalavra>();

            return result;
            }
        }
    }