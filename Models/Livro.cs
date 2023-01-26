using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace api_biblia.Models
{
    public class Livro : Livros
    {
        [JsonProperty("comment")]
        public string Comentario { get; set; }

        public Livro(string name, string author, int chapters, string group, string testament, string comment) {

            this.Nome= name;
            this.Autor= author;
            this.Capitulos= chapters;
            this.Grupo= group;
            this.Testamento= testament;
            this.Comentario= comment;
        }
    }
}
