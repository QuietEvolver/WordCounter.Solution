using System; 
using System.Collections.Generic; 

namespace WordCounter.Models
{
    public class Counter 
    {
        
        public static int Count { get; set; }
        public char[] Word { }; //public char[] ToCharArray()
        public char[] Sentence; //public char[]  ToCharArray(int startIndex, int length)

        public Counter ( char word, char sentence )
        {
            Count = 0;
            Word = word; 
            Sentence = sentence; 
        }
     
        //fre

       // public Word 
    }
}