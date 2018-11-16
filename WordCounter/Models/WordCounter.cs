using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public static class RepeatCounter
  {
    // Properties
    private string Word;
    private string Sentence;

    // Constructor
    public RepeatCounter(string inputWord, string inputSentence)
    {
      Word = inputWord;
      Sentence = inputSentence;
    }
    // objects
    public string[] GetSentence()
    {
     return Sentence;
   }
   public SetSentence()
   {
     string words = Sentence.Split(' ');
     return words;
   }

   public int CountWords()
   {
     int result = 0;
     foreach (string word in words)
     {
       if (word == Word)
     {
       result++;
     }
   }
     return result;
   }


//     public static void Main()
//     {
//       // Console.WriteLine("Enter a word: ");
//       // string inputWord = Console.ReadLine();
//       Console.WriteLine("Enter a sentence: ");
//       string inputSentence = Console.ReadLine();
  }

}
