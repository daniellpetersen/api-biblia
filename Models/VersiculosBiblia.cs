using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace api_biblia.Models
{
    
    public class VersiculosBiblia
    {
        public Book? Book { get; set; }

        [JsonProperty("chapter")]
        public string? Capitulo { get; set; }

        [JsonProperty("number")]
        public string? Versiculo { get; set; }

        [JsonProperty("text")]
        public string? Texto { get; set; }
        
    }
}


