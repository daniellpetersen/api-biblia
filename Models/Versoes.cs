using Newtonsoft.Json;

namespace api_biblia.Models
{
    public class Versoes
    {
        [JsonProperty("version")]
        public string Versao { get; set; }

        [JsonProperty("verses")]
        public int QuantidadeVersiculos { get; set; }
    }
}
