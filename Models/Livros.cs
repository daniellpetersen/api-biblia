using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace api_biblia.Models
{
    public class Livros
    {
        [JsonProperty("abbrev")]
        public Abbrev Abreviatura { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }
        
        [JsonProperty("author")]
        public string Autor { get; set; }

        [JsonProperty("chapters")]
        public int Capitulos { get; set; }

        [JsonProperty("group")]
        public string Grupo { get; set; }

        [JsonProperty("testament")]
        public string Testamento { get; set; }
    }
}
