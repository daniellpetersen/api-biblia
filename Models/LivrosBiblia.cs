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
        public Book(Abbrev abbrev, string name, string author, string group, string version)
        {
            Abbrev = abbrev;
            Name = name;
            Author = author;
            Group = group;
            Version = version;
        }
        public Abbrev Abbrev { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Group { get; set; }
        public string Version { get; set; }

    }

    public class Chapter
    {
        public Chapter(int number, int verses)
        {
            Number = number;
            Verses = verses;
        }

        public int Number { get; set; }
        public int Verses { get; set; }
    }

    public class Verse
    {
        public Verse(int number, string text)
        {
            Number = number;
            Text = text;
        }

        public int Number { get; set; }
        public string Text { get; set; }
    }

    public class LivrosBiblia
    {

        public Book Book { get; set; }
        public Chapter Chapter { get; set; }
        public IEnumerable<Verse> Verses { get; set; }

    }
}
