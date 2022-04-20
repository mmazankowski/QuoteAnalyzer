using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteAnalyzer
{
    public class QuoteTools
    {
        // Count # of words
        public int WordCount (string quote)
        {
            string[] words = quote.Split(' ');

            int numWords = 0;

            numWords = words.Length;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]); 
            //}

            return numWords; 
        }

        // Count # of characters
        public int CharacterCount (string quote)
        {
            int numCharacters = 0;

            numCharacters = quote.Length;

            return numCharacters; 

        }

        // Count # of letters
        public void LetterCount (string quote)
        {
            char ch = ' ';

            // int array of letters 
            int[] letters = new int[26];

            // Count the letters
            for (int i = 0; i < quote.Length; i++)
            {
                ch = quote[i];
                ch = Char.ToUpper(ch); 

                //check to see if the character is a letter
                if (ch >= 'A' && ch <= 'Z')
                {
                    letters[(ch - 65)]++; 
                }
            }

            //Print results
            for (int i = 0; i < letters.Length; i++)
            {
                char letterSymbol = ' ';

                letterSymbol = (char) (i + 65);

                Console.WriteLine(letterSymbol + ": " + letters[i]); 
            }
        }
    }
}
