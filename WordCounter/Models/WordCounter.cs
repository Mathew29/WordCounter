using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordCounter
  {
    private string KeyWord;
    private string sentJoin;
    List<string> sentence = new List<string>()
    {
      // {"I can do this and I can do that but I cannot do it"}
      // {"I"},{"can"}, {"do"}, {"this"}, {"and"}, {"I"}, {"can"}, {"do"}, {"that"}, {"but"}, {"I"}, {"cannot"}, {"do"}, {"it"}
    };

    public WordCounter(string keyWord, string userSent)
    {
      KeyWord = keyWord.ToLower();
      sentJoin = userSent;
      string[] sentSplit = userSent.Split(' ');
      for(int i = 0; i < sentSplit.Length; i++)
      {
        sentence.Add(sentSplit[i]);
      }
    }
    public string getSentence()
    {
      return sentJoin;
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
        if (item.ToLower() == input)
        {
          return true;
        }
      }
      return false;
    }

    public bool CheckSentenceForFullKeyword(string keyWord)
    {
      string input = keyWord.ToLower();
      foreach(string item in sentence)
      {
        if (item.ToLower() == input)
        {
          return false;
        }
      }
      return true;
    }

    public int RepeatCounter(string keyWord)
    {
      string input = keyWord.ToLower();
      int counter = 0;
      foreach(string item in sentence)
      {
        if (item.ToLower() == input)
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
