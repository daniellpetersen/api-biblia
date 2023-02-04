using api_biblia.Models;
using Flurl;
using Flurl.Http;

namespace api_biblia.Services
{
    public class UpdateUserTokenService
    {
        public async Task<UpdateUser> AlterarToken(string email, string senha)
        {

            var result = await "https://www.abibliadigital.com.br/api/users/"
                .AppendPathSegments("token")
                .PutJsonAsync(new { email, password = senha})
                .ReceiveJson<UpdateUser>();

            return result;
        }
    }
}