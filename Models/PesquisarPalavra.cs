using Newtonsoft.Json;

namespace api_biblia.Models
{
    public class Verses
    {
        public Book? Book { get; set; }
        public string? Chapters { get; set; }

        public string? Testament { get; set; }


        public Abbrev? Abreviatura { get; set; }
    }


    public class PesquisarPalavra
    {
        [JsonProperty("occurrence")]
        public string? Ocorrência { get; set; }

        [JsonProperty("version")]
        public string? Versão { get; set; }

       public IEnumerable<Verses>? Verses { get; set; }
        

    }
}
