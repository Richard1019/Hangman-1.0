namespace Hangman_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
           const int HANGMAN_PIECES = 8;

           List<string> WordList = new List<string>();

           WordList.Add("aircraft");
           WordList.Add("bootcamp");
           WordList.Add("pizzeria");

           Console.WriteLine("Hello, let us play some Hangman.");
           Console.WriteLine("I`m gonna choose a word, you try to guess it by choosing letters");
           // Console.WriteLine(WordList[1]);

           Console.WriteLine("Ok, I am ready! Go a head, guess those letters!");

            string YourFirstLetter = Console.ReadLine();





           
        }
    }
}
