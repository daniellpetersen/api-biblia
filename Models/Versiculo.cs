namespace api_biblia.Models
{
    public class Versiculo
    {
        public Versiculo(int number, string text)
        {
            Number = number;
            Text = text;
        }

        public int Number { get; set; }
        public string Text { get; set; }
    }
}
