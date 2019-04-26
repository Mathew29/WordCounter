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
      WordCounter wordCounter = new WordCounter("can");
      Assert.AreEqual("can", wordCounter.GetKeyWord());
    }
    [TestMethod]
    public void TestSentenceForKeyword()
    {
      WordCounter wordCounter = new WordCounter("can");
      Assert.AreEqual(true, wordCounter.CheckSentenceForKeyword("can"));
    }
    [TestMethod]
    public void CheckHowManyTimesKeywordIsInSentence()
    {
      WordCounter wordCounter = new WordCounter("can");
      Assert.AreEqual(2, wordCounter.RepeatCounter("can"));
    }

  }
}