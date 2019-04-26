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
      WordCounter wordCounter = new WordCounter("bear");
      Assert.AreEqual("bear", wordCounter.GetKeyWord());
    }
    [TestMethod]
    public void TestSentenceForKeyword()
    {
      WordCounter wordCounter = new WordCounter("bear");
      Assert.AreEqual(true, wordCounter.CheckSentenceForKeyword("bear"));
    }
  }
}
