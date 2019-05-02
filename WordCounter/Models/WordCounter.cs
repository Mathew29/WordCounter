using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordCounter
  {
    //User input word and User input sentece
    private string _keyWord;
    private string _sentenceJoin;

    //List that contains the sentece
    List<string> sentence = new List<string>()
    {
      // {"I can do this and I can do that but I cannot do it"}
      // {"I"},{"can"}, {"do"}, {"this"}, {"and"}, {"I"}, {"can"}, {"do"}, {"that"}, {"but"}, {"I"}, {"cannot"}, {"do"}, {"it"}
    };

    public WordCounter(string keyWord, string userSentence)
    {
      //change user input word to all lower case for test purposes
      _keyWord = keyWord.ToLower();
      _sentenceJoin = userSentence;
      //Break up sentece into a string array
      string[] sentenceSplit = userSentence.Split(' ');
      //Adds the string array of sentence to the List
      for(int i = 0; i < sentenceSplit.Length; i++)
      {
        sentence.Add(sentenceSplit[i]);
      }
    }

    //Test for UserInput word
    public string GetKeyWord()
    {
      return _keyWord;
    }
    //Test for UserInput sentece
    public string GetSentence()
    {
      return _sentenceJoin;
    }

    //Test to check if the keyword is inside the sentence
    public bool CheckSentenceForKeyword(string keyWord)
    {
      //changes user input word to lowercase
      string input = keyWord.ToLower();
      //Loop through every word in the sentence
      foreach(string item in sentence)
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
      foreach(string item in sentence)
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
      int counter = 0;
      foreach(string item in sentence)
      {
        //turns all words in the list to lowercase
        //checks to see if the word in the list matches with the keyWord
        if (item.ToLower() == input)
        {
          //Add one for every match of Keyword
          counter +=1;
        }
      }
      return counter;
    }
  }
}
