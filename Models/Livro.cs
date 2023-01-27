using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace api_biblia.Models
{
    public class Livro : Livros
    {
        [JsonProperty("comment")]
        public string? Comentario { get; set; }

       
    }
}
