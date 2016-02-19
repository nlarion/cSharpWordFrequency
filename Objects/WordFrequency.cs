using System;
using System.Linq;
using System.Collections.Generic;

namespace WordFrequency
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _word;

    public RepeatCounter (string sentence, string word)
    {
      _sentence = sentence;
      _word = word;
    }

    public int CountRepeats()
    {
      return 0;
    }

    public static char[] ReturnLowerCharArrayFromString(string word)
    {
      return word.ToLower().ToCharArray();
    }

  }
}
