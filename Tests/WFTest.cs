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
    public void TestRepeatCounter2()
    {
      Assert.Equal(2, RepeatCounter.CountRepeats("Hello world! This is a complex sentence with multiple things to try and trick the counter. What a WORLD.","world"));
    }    
    
    [Fact]
    public void TestReturnLowerCharArray()
    {
      Assert.Equal(new char[]{'w','o','r','l','d'}, RepeatCounter.LowerCharArrayFromString("WORLD"));
    }    

    [Fact]
    public void TestReturnListOfWordsFromSentence()
    {
      Assert.Equal(new List<string>{"This","is","a","split","sentence"}, RepeatCounter.ListOfWordsFromSentence("This is a split sentence"));
    }

    [Fact]
    public void TestReturnTrueWhenCharArraysAreEqual()
    {
      Assert.Equal(true, RepeatCounter.TrueWhenCharArraysAreEqual(new char[]{'y','e','s'},new char[]{'y','e','s'}));
    }
  }
}
