using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordCounter
  {
    string Keyword;

    List<string> WordList = new List<string>();

    public WordCounter(string keyWord)
    {
      Keyword = keyWord;
    }

    public string GetKeyWord()
    {
      return Keyword;
    }
  }
}
