using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordCounter
  {
    string KeyWord;

    List<string> sentence = new List<string>()
    {
      {"A"},{"big"}, {"bear"}
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
      foreach(string item in sentence)
      {
        if (item == keyWord)
        {
          return true;
        }
      }
      return false;
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
