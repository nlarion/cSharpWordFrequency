using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;

namespace  WordFrequency
{
  public class RepeatCounterTest
  {
    [Fact]
    public void TestRepeatCounter()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("Hello world","world"));
    }    
    
    [Fact]
    public void TestReturnLowerCharArray()
    {
      Assert.Equal(new char[]{'w','o','r','l','d'}, RepeatCounter.ReturnLowerCharArrayFromString("WORLD"));
    }    

    [Fact]
    public void TestReturnListOfWordsFromSentence()
    {
      Assert.Equal(new List<string>{"This","is","a","split","sentence"}, RepeatCounter.ReturnListOfWordsFromSentence("This is a split sentence"));
    }

    [Fact]
    public void TestReturnTrueWhenCharArraysAreEqual()
    {
      Assert.Equal(true, RepeatCounter.ReturnTrueWhenCharArraysAreEqual(new char[]{'y','e','s'},new char[]{'y','e','s'}));
    }
  }
}
