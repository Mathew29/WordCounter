using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    //User input word and User input sentece
    public string KeyWord {get; set;}
    public string UserSentence {get; set;}
    public int Matches {get;}
    public static List<Counter> MatchList {get; set;} = new List<Counter> {};
    public int Id {get; set;}


    public Counter(string keyWord, string userSentence)
    {
      //change user input word to all lower case for test purposes
      string lowerCaseKeyWord = keyWord.ToLower();
      KeyWord = lowerCaseKeyWord;
      UserSentence = userSentence;
      Matches = this.RepeatCounter();
      MatchList.Add(this);
      Id = MatchList.Count;
    }

    public int RepeatCounter()
    {
      //changes user input word to lowercase

      int counter = 0;
      string[] sentenceSplit = UserSentence.Split(' ');
      foreach(string word in sentenceSplit)
      {
        if (word.ToLower() == KeyWord)
        {
          //Add one for every match of Keyword
          counter +=1;
        }
      }
      return counter;
    }

    public static void ClearAll()
    {
      MatchList.Clear();
    }

    public static Counter Find(int searchId)
    {
      return MatchList[searchId-1];
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
