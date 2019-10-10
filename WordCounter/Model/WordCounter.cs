using System; 
using System.Collections.Generic; 
using System.Linq;
using WordCounter.Model; 

namespace WordCounter.Model
{
    public class Counter 
    {
        public string Word { get; set; } 
        public string Sentence { get; set; } 
        public char[] WordStrToCharArr { get; set; }
       

        public Counter ( string word, string sentence )
        {
            Word = word;
            Sentence = sentence;  
        }
         public int WordCount( )
         {
            int Count = 0; 
            string[] SentenceStrToArr = Sentence.Split(new Char[]  { ' ', '.', ',', '/', '\n', '!', '?'}); 
            for(int i = 0; i < SentenceStrToArr.Length; i++)
            {
                if( Word == SentenceStrToArr[i])
                {
                    Count++;
                }
            }
            return Count;
        }
    }
}