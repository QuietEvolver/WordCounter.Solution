using System; 
using System.Collections.Generic;
using System.Linq;
using WordCounter.Model; 

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {   
            List <Counter> BaseCounter = new List <Counter>(){};
            Console.WriteLine("Welcome to WordCounter");
            Console.WriteLine("Enter in a word: ");
            string Word = Console.ReadLine();            
            Console.WriteLine("Enter in a sentence: ");
            string Sentence = Console.ReadLine();
            
            Counter newBaseCounter = new Counter(Word.ToUpper(), Sentence.ToUpper());
            int result = newBaseCounter.WordCount();           
            char[]  WordCharArr =  (Word.ToUpper()).ToCharArray();
            bool resultWordChar; 
            resultWordChar = Char.IsLetter(WordCharArr[0]);
            Console.WriteLine("weighted result: " + result);
            Console.WriteLine("Input Str: " + Sentence + "\nWord: " + Word );            
        }
    }
}
