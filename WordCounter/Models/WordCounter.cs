using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordCounter
  {
    //User input word and User input sentece
    private string _keyWord;
    private string _userSentence;
    private string[] sentenceSplit;
    private int _counter;
    // private int _id;
    // private static List<Item> _instances = new List<Item> {};


    public WordCounter(string keyWord, string userSentence)
    {
      //change user input word to all lower case for test purposes
      _keyWord = keyWord.ToLower();
      _userSentence = userSentence;
      //Break up sentece into a string array
      sentenceSplit = userSentence.Split(' ');
      _counter = 0;
      // _instances.Add(this.keyWord);
      // _id = _instances.Count;
    }
    //Test for UserInput word
    public string GetKeyWord()
    {
      return _keyWord;
    }
    //Test for UserInput sentece
    public string GetSentence()
    {
      return _userSentence;
    }

    public int GetCounter()
    {
      return _counter;
    }

    // public int GetId()
    // {
    //   return _id;
    // }
    //
    // public static List<Item> GetAll()
    // {
    //   return _instances;
    // }
    //
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
    //
    // public static WordCounter Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }

    //Test to check if the keyword is inside the sentence
    public bool CheckSentenceForKeyword(string keyWord)
    {
      //changes user input word to lowercase
      string input = keyWord.ToLower();
      //Loop through every word in the sentence
      foreach(string item in sentenceSplit)
      {
        //turns all words in the list to lowercase
        //checks to see if the word in the list matches with the keyWord
        if (item.ToLower() == input)
        {
          return true;
        }
      }
      return false;
    }
    //Test to check that only the full keywords return and not words with the keyword inside them
    public bool CheckSentenceForFullKeyword(string keyWord)
    {
      //changes user input word to lowercase
      string input = keyWord.ToLower();
      foreach(string item in sentenceSplit)
      {
        //turns all words in the list to lowercase
        //checks to see if the word in the list matches with the keyWord
        if (item.ToLower() == input)
        {
          return false;
        }
      }
      return true;
    }
    //Test to check how many keywords are inside the sentence
    public int RepeatCounter(string keyWord)
    {
      //changes user input word to lowercase
      string input = GetKeyWord().ToLower();
      foreach(string item in sentenceSplit)
      {
        //turns all words in the list to lowercase
        //checks to see if the word in the list matches with the keyWord
        if (item.ToLower() == input)
        {
          //Add one for every match of Keyword
          _counter +=1;
        }
      }
      return _counter;
    }
  }
}
