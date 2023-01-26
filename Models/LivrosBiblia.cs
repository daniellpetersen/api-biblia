
namespace api_biblia.Models;

public class Book
{
    public Book(string abbrev, string name, string author, string group, string version)
    {
        Abbrev = abbrev;
        Name = name;
        Author = author;
        Group = group;
        Version = version;
    }

    public string Abbrev { get; set; }
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


public class LivrosBiblia
{
    public Book books { get; set; }
    public Chapter chapters { get; set; }
    public Verses verses { get; set; }


    }

