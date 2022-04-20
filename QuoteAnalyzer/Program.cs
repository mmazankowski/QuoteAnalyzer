using System;

namespace QuoteAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // bring in quote tools
            QuoteTools qt = new QuoteTools();

            string userQuote = "";

            Console.WriteLine("Welcome to quote analyzer");
            Console.WriteLine("Please enter a quote: ");
            userQuote = Console.ReadLine();

            Console.WriteLine("Characters: " + qt.CharacterCount(userQuote));
            Console.WriteLine("Words: " + qt.WordCount(userQuote));
            Console.WriteLine("Count of Letters: ");
            qt.LetterCount(userQuote); 
        }
    }
}
