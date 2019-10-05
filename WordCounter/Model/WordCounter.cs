using System; 
using System.Collections.Generic; 
using System.Linq;
using WordCounter.Models; 

namespace WordCounter.Models
{
    public class Counter 
    {
        
        public static int count = 0; //numOfWord = 0;
        public string Word { get; set; } //public char[] ToCharArray()
        public string Sentence { get; set; } //public char[]  ToCharArray(int startIndex, int length)
        public char[] StrToCharArr { get; set; }
                
        public Counter ( string word, string sentence , char[] strToCharArr)
        {
            Word = word;
            Sentence = sentence;  
            StrToCharArr = strToCharArr;
        }
     
        //public virtual bool Equals(object word) //public char[] Word

       // public Sent 
    }

   // public class Word 
}