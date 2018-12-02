using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    // Properties
    private string _word;
    private string _sentence;

    // Constructor
    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }

    public string[] SplitSentence()
    {
      string[] words = _sentence.Split(' ');
      return words;
    }

    public int CountWords()
    {
      int result = 0;
      foreach (string word in SplitSentence())
      {
        if (word == _word)
        {
          result++;
        }
      }
      return result;
    }
  }
}
