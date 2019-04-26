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
      WordCounter wordCounter = new WordCounter("Justice");
      Assert.AreEqual("justice", wordCounter.GetKeyWord());
    }
    [TestMethod]
    public void TestSentenceForKeyword()
    {
      WordCounter wordCounter = new WordCounter("I");
      Assert.AreEqual(true, wordCounter.CheckSentenceForKeyword("I"));
    }
    [TestMethod]
    public void CheckHowManyTimesKeywordIsInSentence()
    {
      WordCounter wordCounter = new WordCounter("can");
      Assert.AreEqual(2, wordCounter.RepeatCounter("can"));
    }

  }
}
