using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordCounter
  {
    string KeyWord;

    List<string> sentence = new List<string>()
    {
      {"I"},{"can"}, {"do"}, {"this"}, {"and"}, {"I"}, {"can"}, {"do"}, {"that"}, {"but"}, {"I"}, {"cannot"}, {"do"}, {"it"}
    };

    public WordCounter(string keyWord)
    {
      KeyWord = keyWord;
    }

    public string GetKeyWord()
    {
      return KeyWord;
    }

    public bool CheckSentenceForKeyword(string keyWord)
    {
      string input = keyWord.ToLower();
      foreach(string item in sentence)
      {
        if (item == input)
        {
          return true;
        }
      }
      return false;
    }

    public int RepeatCounter(string keyWord)
    {
      string input = keyWord.ToLower();
      int counter = 0;
      foreach(string item in sentence)
      {
        if (item == input)
        {
          counter +=1;
        }
      }
      return counter;
    }
  }
}






// if (item.Length == KeyWord.Length)
// {
//   char[] checkKeyWord = KeyWord.ToCharArray();
//   char[] checkListWord = item.ToCharArray();
//
//   for (int i = 0; i < checkKeyWord.Length; i++)
//   {
//     if (checkKeyWord[i] == checkListWord[i])
//     {
//       return true;
//     }
//   }
// }
