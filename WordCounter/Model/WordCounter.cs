using System; 
using System.Collections.Generic; 
using System.Linq;
using WordCounter.Models; 

namespace WordCounter.Models
{
    public class Counter 
    {
        public static int Count = 0; //numOfWord = 0;
        public string Word { get; set; } //public char[] ToCharArray()
        public char[] WordStrToCharArr { get; set; }  
        public string Sentence { get; set; } 
        // public char[] SentenceStrToCharArr { get; set; }  
        public char[] CharSentenceWordToCharArr { get; set; }  
        
        //public char[]  ToCharArray(int startIndex, int length)
                
        public Counter ( string word, string sentence )//, char[] wordStrToCharArr)
        {
            Word = word;
            Sentence = sentence;  
            // WordStrToCharArr = Word.ToCharArray();
            // SentenceStrToCharArr = Sentence.ToCharArray();
            // //SentenceStrToCharArr = SentenceWord.ToCharArray();
            // Console.WriteLine("WordStrToCharArr" + WordStrToCharArr + "/SentenceStrToCharArr: " + SentenceStrToCharArr);
            // Count = 0;
        }
         public int WordCount( )
         {
            int Count = 0; 
          // Separator =;
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
            // public Sent SentWordStrToCharArr = sentWrdStrToCharArr; public char[] SentWordStrToCharArr [i]{ get; set; } 
            //public virtual bool Equals(object word) //public char[] Word
            // public bool IsWord(int Count)
            // {
            //     bool result = true;
            //     return result;
            //     // for(int i = 0; i < WordStrToCharArr.Length; i++)
            //     // {
            //     //     string[] SentenceStrToCharArr = this.resultSentenceParse;
            //     //     if(!(Char.IsLetterWordStrToCharArr[i] == (Char.IsLetter(CharSentenceWordToCharArr[i])))
            //     //     {
                        
            //     //         Count = SentenceWordStrToCharArr.Equals(Word)? ++Count: Count;//.Next();
            //     //     }
            //     //
            //     // return Count;
            // //     // Console.WriteLine("EvalWord()isLetter: " + );
            // //     WordStrToCharArr.IsLetter(0, 0);
            // }
    }

}