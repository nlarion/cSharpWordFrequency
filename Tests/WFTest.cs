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
      RepeatCounter repeatCounter = new RepeatCounter("Hello world","world");
      Assert.Equal(1, repeatCounter.CountRepeats());
    }

    [Fact]
    public void TestRepeatCounterForEmpty()
    {
      RepeatCounter repeatCounter = new RepeatCounter("","");
      Assert.Equal(0, repeatCounter.CountRepeats());
    }

    [Fact]
    public void TestRepeatCounterLongTest()
    {
      RepeatCounter repeatCounter = new RepeatCounter("Hello world! This is a complex sentence with multiple things to try and trick the counter. What a WORLD.","world");
      Assert.Equal(2, repeatCounter.CountRepeats());
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