using System;
using System.Linq;
using System.Collections.Generic;

namespace WordFrequency
{
  public class RepeatCounter
  {
    // private string _sentence;
    // private string _word;

    // public RepeatCounter (string sentence, string word)
    // {
    //   _sentence = sentence;
    //   _word = word;
    // }

    public static int CountRepeats(string sentence, string word)
    {
      return 0;
    }

    public static char[] ReturnLowerCharArrayFromString(string word)
    {
      return word.ToLower().ToCharArray();
    }

    public static List<string> ReturnListOfWordsFromSentence(string sentence)
    {
      List<string> returnList = new List<string>{};
      string[] stringArray = sentence.Split(' ',',','.','!','?');
      foreach(string singleString in stringArray)
      {
        returnList.Add(singleString);
      }
      return returnList;
    }

    public static bool ReturnTrueWhenCharArraysAreEqual(char[] charArray1, char[] charArray2)
    {
      if(charArray1.SequenceEqual(charArray2))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
