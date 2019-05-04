// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using WordCounter;
// using System.Collections.Generic;
//
// namespace WordCounter.Tests
// {
//   [TestClass]
//   public class CounterTest
//   {
//     [TestMethod]
//     public void TestKeywordReturns()
//     {
//       Counter wordCounter = new Counter("Justice", "hold sentence");
//       Assert.AreEqual("justice", wordCounter.GetKeyWord());
//     }
//
//     [TestMethod]
//     public void CheckReturnedSentence()
//     {
//       string test = "this is a test sentence";
//       Counter wordCounter = new Counter("can", test);
//       Assert.AreEqual(test, wordCounter.GetSentence());
//     }
//     [TestMethod]
//     public void TestSentenceForKeyword()
//     {
//       Counter wordCounter = new Counter("Can", "I can do this and I can do that but I cannot do it");
//
//       Assert.AreEqual(true, wordCounter.CheckSentenceForKeyword("Can"));
//     }
//     [TestMethod]
//     public void TestSentenceForFullKeyword()
//     {
//       Counter wordCounter = new Counter("Can", "Cannot");
//
//       Assert.AreEqual(true, wordCounter.CheckSentenceForFullKeyword("Can"));
//     }
//     [TestMethod]
//     public void CheckHowManyTimesKeywordIsInSentence()
//     {
//       Counter wordCounter = new Counter("can", "I can do this and I can do that but I cannot do it");
//       Assert.AreEqual(2, wordCounter.GetCounter("can"));
//     }
//
//
//   }
// }
