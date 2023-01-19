namespace api_biblia.Models
{
    public class LivrosBiblia
    {
        public class Book
        {
            public Book(string name, string author, string group, string version)
            {
                Name = name;
                Author = author;
                Group = group;
                Version = version;
            }

            public class Abrev
            {
                public Abrev(string pt, string en)
                {
                    Pt = pt;
                    En = en;
                }

                public string Pt { get; set; }
                public string En { get; set;}
            }
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

        public class Verses
        {
            public Verses(int number, string text)
            {
                Number = number;
                Text = text;
            }

            public int Number { get; set; }
            public string Text { get; set; }
        }


       // public List<Capitulo> Capitulo { get; set; }
    
    }
}
