using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace api_biblia.Models
{
    public class Abbrev
    {
        public Abbrev(string pt, string en)
        {
            Pt = pt;
            En = en;
        }

        public string Pt { get; set; }
        public string En { get; set; }

    }
    public class Book
    {
  
        [JsonProperty("abbrev")]
        public Abbrev? Abreviatura { get; set; }

        [JsonProperty("name")]
        public string? Nome { get; set; }

        [JsonProperty("author")]
        public string? Autor { get; set; }

        [JsonProperty("group")]
        public string? Grupo { get; set; }

        [JsonProperty("version")]
        public string? Versao { get; set; }

    }

    public class Chapter
    {
        [JsonProperty("number")]
        public int? Capitulo { get; set; }

        [JsonProperty("verses")]
        public int? QuantidadeVersiculos { get; set; }
    }

    public class Verse
    {
        [JsonProperty("number")]
        public int? Versiculo { get; set; }

        [JsonProperty("text")]
        public string? Texto { get; set; }
    }

    public class CapituloBiblia
    {
        public Book? Book { get; set; }
        public Chapter? Chapter { get; set; }
        public IEnumerable<Verse>? Verses { get; set; }

    }
}


