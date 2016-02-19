using System;
using System.Linq;
using System.Collections.Generic;

namespace WordFrequency
{
  public static class RepeatCounter
  {
    public static int CountRepeats(string sentence, string word)
    {
      int returnInt = 0;
      List<string> sentenceWords = ListOfWordsFromSentence(sentence);
      foreach(string singleWord in sentenceWords)
      {
        if (TrueWhenCharArraysAreEqual(LowerCharArrayFromString(word),LowerCharArrayFromString(singleWord)))
        {
          returnInt++;
        }
      }
      return returnInt;
    }

    public static char[] LowerCharArrayFromString(string word)
    {
      return word.ToLower().ToCharArray();
    }

    public static List<string> ListOfWordsFromSentence(string sentence)
    {
      List<string> returnList = new List<string>();
      string[] stringArray = sentence.Split(' ',',','.','!','?');
      foreach(string singleString in stringArray)
      {
        returnList.Add(singleString);
      }
      return returnList;
    }

    public static bool TrueWhenCharArraysAreEqual(char[] charArray1, char[] charArray2)
    {
      if(charArray1.Length == 0 || charArray2.Length == 0)
      {
        return false;
      } 
      return charArray1.SequenceEqual(charArray2);
    }
  }
}