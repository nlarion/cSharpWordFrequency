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
      char[] userWordCharArray = LowerCharArrayFromString(word);
      List<string> sentenceWords = ListOfWordsFromSentence(sentence);
      foreach(string singleWord in sentenceWords)
      {
        char[] singleWordCharArray = LowerCharArrayFromString(singleWord);
        if (TrueWhenCharArraysAreEqual(userWordCharArray,singleWordCharArray))
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
      return charArray1.SequenceEqual(charArray2);
    }
  }
}
