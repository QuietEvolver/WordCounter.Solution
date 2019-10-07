using System; 
using System.Collections.Generic;
using System.Linq;
using WordCounter.Models; 

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
            
            Counter newBaseCounter = new Counter(Word, Sentence);
            int result = newBaseCounter.WordCount();           
            char[]  WordCharArr =  (Word.ToUpper()).ToCharArray();
            bool resultWordChar; 
            resultWordChar = Char.IsLetter(WordCharArr[0]);
            Console.WriteLine("rez resultWordChar: " +  resultWordChar + "weighted result: " + result);

        //    // string[] SentenceSplit 
        //     bool resultSentenceParse; 

        //     char[]  resultSentenceParse =  (Sentence.ToUpper()).ToCharArray(); //CharSentenceArr
      
            Console.WriteLine("Input Str: " + "List: newBaseCounter/newBaseCounter.WordCharArr "+ newBaseCounter +  newBaseCounter.WordStrToCharArr + "\nWord: " + Word + "\nWordCharArr: " + WordCharArr[0]);
        //     Console.WriteLine("Input Str: " + "List: newBaseCounter.SentenceCharArr "+   newBaseCounter.SentenceStrToCharArr + "\nSentence: " + Sentence + "\resultSentenceParse: " + resultSentenceParse[0]);
            
        }

    }
}
