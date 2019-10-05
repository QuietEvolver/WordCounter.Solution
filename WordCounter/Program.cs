using System; 
using System.Collections.Generic;
using WordCounter.Models; 

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to WordCounter");
            Console.WriteLine("Enter in a word: ");
           //bool input; //declaring and checking Char.IsLetter(Char) method
            string inputStr = (Console.ReadLine( ));
            char[] Word = inputStr.ToCharArray(0, (inputStr.length-1));
            Console.WriteLine("Input Str: " + inputStr + "\nWord: " + Word);
        }

    }
}
