namespace api_biblia.Models
{
    public class Capitulo
    {
        public Capitulo(int number, int verses, List<Versiculo> versiculo)
        {
            Number = number;
            Verses = verses;
            Versiculo = versiculo;
        }

        public int Number { get; set; }
        public int Verses { get; set; }

        public List<Versiculo> Versiculo { get; set; }
    }
}
