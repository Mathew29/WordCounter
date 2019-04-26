using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void TestKeywordReturns()
    {
      WordCounter wordCounter = new WordCounter("Justice", "hold sentence");
      Assert.AreEqual("justice", wordCounter.GetKeyWord());
    }

    [TestMethod]
    public void CheckReturnedSentence()
    {
      string test = "this is a test sentence";
      WordCounter wordCounter = new WordCounter("can", test);
      Assert.AreEqual(test, wordCounter.getSentence());
    }
    [TestMethod]
    public void TestSentenceForKeyword()
    {
      WordCounter wordCounter = new WordCounter("Can", "I can do this and I can do that but I cannot do it");

      Assert.AreEqual(true, wordCounter.CheckSentenceForKeyword("Can"));
    }
    [TestMethod]
    public void TestSentenceForFullKeyword()
    {
      WordCounter wordCounter = new WordCounter("Can", "Cannot");

      Assert.AreEqual(true, wordCounter.CheckSentenceForFullKeyword("Can"));
    }
    [TestMethod]
    public void CheckHowManyTimesKeywordIsInSentence()
    {
      WordCounter wordCounter = new WordCounter("can", "I can do this and I can do that but I cannot do it");
      Assert.AreEqual(2, wordCounter.RepeatCounter("can"));
    }


  }
}
