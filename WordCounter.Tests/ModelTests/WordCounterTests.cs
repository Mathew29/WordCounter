// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using WordCounter;
// using System.Collections.Generic;
//
// namespace WordCounter.Tests
// {
//   [TestClass]
//   public class WordsTest
//   {
//     [TestMethod]
//     public void TestKeywordReturns()
//     {
//       Words wordCounter = new Words("Justice", "hold sentence");
//       Assert.AreEqual("justice", wordCounter.GetKeyWord());
//     }
//
//     [TestMethod]
//     public void CheckReturnedSentence()
//     {
//       string test = "this is a test sentence";
//       Words wordCounter = new Words("can", test);
//       Assert.AreEqual(test, wordCounter.GetSentence());
//     }
//     [TestMethod]
//     public void TestSentenceForKeyword()
//     {
//       Words wordCounter = new Words("Can", "I can do this and I can do that but I cannot do it");
//
//       Assert.AreEqual(true, wordCounter.CheckSentenceForKeyword("Can"));
//     }
//     [TestMethod]
//     public void TestSentenceForFullKeyword()
//     {
//       Words wordCounter = new Words("Can", "Cannot");
//
//       Assert.AreEqual(true, wordCounter.CheckSentenceForFullKeyword("Can"));
//     }
//     [TestMethod]
//     public void CheckHowManyTimesKeywordIsInSentence()
//     {
//       Words wordCounter = new Words("can", "I can do this and I can do that but I cannot do it");
//       Assert.AreEqual(2, wordCounter.GetCounter("can"));
//     }
//
//
//   }
// }
