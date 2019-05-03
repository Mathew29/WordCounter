using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Words
  {
    //User input word and User input sentece
    private string _keyWord;
    private string _userSentence;
    private string[] sentenceSplit;
    private int _counter;


    public Words(string keyWord, string userSentence)
    {
      //change user input word to all lower case for test purposes
      _keyWord = keyWord.ToLower();
      _userSentence = userSentence;
      //Break up sentece into a string array
      sentenceSplit = userSentence.Split(' ');
      _counter = 0;
    }
    //Test for UserInput word
    public string GetKeyWord()
    {
      return _keyWord;
    }

    public void SetKeyWord(string newKeyWord)
    {
      _keyWord = newKeyWord;
    }

    //Test for UserInput sentece
    public string GetSentence()
    {
      return _userSentence;
    }

    public void SetSentence(string newSentence)
    {
      _userSentence = newSentence;
    }

    public int GetCounter()
    {
      return _counter;
    }

    public int RepeatCounter()
    {
      //changes user input word to lowercase

      foreach(string item in sentenceSplit)
      {
        //turns all words in the list to lowercase
        //checks to see if the word in the list matches with the keyWord
        if (item.ToLower() == GetKeyWord())
        {
          //Add one for every match of Keyword
          _counter +=1;
        }
      }
      return _counter;
    }


    //Test to check if the keyword is inside the sentence
    // public bool CheckSentenceForKeyword()
    // {
    //
    //   //Loop through every word in the sentence
    //   foreach(string item in sentenceSplit)
    //   {
    //     //turns all words in the list to lowercase
    //     //checks to see if the word in the list matches with the keyWord
    //     if (item.ToLower() == input)
    //     {
    //       return true;
    //     }
    //   }
    //   return false;
    // }
    // //Test to check that only the full keywords return and not words with the keyword inside them
    // public bool CheckSentenceForFullKeyword()
    // {
    //   foreach(string item in sentenceSplit)
    //   {
    //     //turns all words in the list to lowercase
    //     //checks to see if the word in the list matches with the keyWord
    //     if (item.ToLower() == input)
    //     {
    //       return false;
    //     }
    //   }
    //   return true;
    // }
    //Test to check how many keywords are inside the sentence
  }
}
