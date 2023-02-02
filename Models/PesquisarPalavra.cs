using Newtonsoft.Json;

namespace api_biblia.Models
{
    public class Verses
    {
        public Verses(Livros? book, string? chapter, int? number, string? text)
        {
            Livros = book;
            Capitulo = chapter;
            Numero = number;
            Texto = text;
        }
        public Livros? Livros { get; }

        [JsonProperty("chapter")]
        public string? Capitulo { get; set; }

        [JsonProperty("number")]
        public int? Numero { get; set; }

        [JsonProperty("text")]
        public string? Texto { get; set; }
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
