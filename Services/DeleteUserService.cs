
using api_biblia.Models;
using Flurl;
using Flurl.Http;
using System;


namespace api_biblia.Services
{
    public class DeleteUserService
    {
       
        public async Task<HttpResponseMessage> Remover(string email, string password)
        {
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IldlZCBGZWIgMDggMjAyMyAwMTo1NToyMiBHTVQrMDAwMC42M2UyODcwZDhmNjI2OTAwMjJiMWQ5MmIiLCJpYXQiOjE2NzU4MjEzMjJ9.gz6rB1WHq_Iq4TNax3TD40BmD8YVPb-vg7QkOxDw9Kk";
            var repo = new UsuarioDeletar
            {
                Email = email,
                Password = password,
            };

            var url = "https://www.abibliadigital.com.br/api/users";
            var result = await url

                .WithHeader("Accept", "application/json")
                .AllowAnyHttpStatus()

                .WithOAuthBearerToken(token)
                
                .SendJsonAsync(HttpMethod.Delete, repo);
           
                     return result.ResponseMessage;

         }
    }
}
