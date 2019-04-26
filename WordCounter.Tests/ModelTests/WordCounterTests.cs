using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

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
  }
}
