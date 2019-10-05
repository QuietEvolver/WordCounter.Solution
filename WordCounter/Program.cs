using System; 
using System.Collections.Generic;
using System.Linq;
using WordCounter.Models; 

namespace WordCounter.WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to WordCounter");
            Console.WriteLine("Enter in a word: ");
            string newWord = Console.ReadLine();
            // char[] newWordArr = newWord.ToCharArray(
            //    // char[] newWordArr = new char[0][]{
            // //}
            // );
            
            // //char[] WordArr =  
            // char[] res = newWordArr.ToDictionary(item => item);// item.Value.ToCharArray());
            // 
               // WordArr = Word.ToCharArray();
              // char[]  WordCharArr = newWord.ToCharArray(Console.ReadLine());
            //newWord = Word;//str
          
            //char[] Word = newWord0][newWord.length-1]; //inputStr.ToUpper(0, (inputStr.length-1));//0, (inputStr.length-1));
            //  char[] inputStr = input;
            Console.WriteLine("Input Str: " + newWord); //+ "\nWord: " + Word);
        }

    }
}
