using api_biblia.Models;
using Flurl;
using Flurl.Http;

namespace api_biblia.Services
{
    public class AlterarSenhaUserService
    {
        public async Task<AlteraSenhaUser> BuscarEmail(string email)
        {

            var result = await "https://www.abibliadigital.com.br/api/users/password/"
                .AppendPathSegments(email)
                .PostJsonAsync(new { email })
                .ReceiveJson<AlteraSenhaUser>();

            return result;
        }
    }
}

