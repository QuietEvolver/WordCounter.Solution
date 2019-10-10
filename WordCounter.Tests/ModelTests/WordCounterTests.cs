using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Model;

namespace WordCounter.Tests
{
    [TestClass]
    public class CounterTests
    {   // * Gather an input word | I: "test" | O: N/A
        [TestMethod]
        
        public void  Counter_IsWordInput()
        {   
            //Arrange: Instance of forecasted result
            Counter myCounter = new Counter("testWord", "this is a test");
            //Act: Variable test instances
            string thisTestWord = myCounter.Word;
            //Assert: Assert.AreEqual(result, forecast);
            Assert.AreEqual(thisTestWord, "testWord");
        }
        // * Gather an input sentence | I: "This is a test." | O: N/A
        [TestMethod]
        public void  Counter_IsSentenceInput()
        {
            //Arrange:  
            Counter myCounter = new Counter("test", "This is a test sentence.");
            //Act:
            string thisTestSentence = myCounter.Sentence;
            //Assert: 
            Assert.AreEqual(thisTestSentence, "This is a test sentence.");
        }
        //* Show user the frequency of their original inputted word, full word only, against the inputted sentence: | I: "test" | O: N/A
        [TestMethod]
        public void Counter_IsCounted()
         {
            //Arrange:
            Counter myCounter = new Counter("test", "this is a test");
            //Act: 
            int thisTestCount = myCounter.WordCount();
            //Assert: 
            Assert.AreEqual(thisTestCount, 1);
        }
    }
}