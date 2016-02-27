using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;

namespace  WordFrequency
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Test_RepeatCounter_MatchSimpleWordInJustOneWord()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("world","world"));
    }

    [Fact]
    public void Test_RepeatCounter_MatchSimpleSentenceInTwoWords()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("Hello world","world"));
    }

    [Fact]
    public void Test_RepeatCounter_MatchSimpleSentenceInThreeWords()
    {
      Assert.Equal(3, RepeatCounter.CountRepeats("world world world","world"));
    }

    [Fact]
    public void Test_RepeatCounter_MatchSimpleSentenceWithACapitalLetter()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("Hello World","world"));
    }

    [Fact]
    public void Test_RepeatCounter_MatchSimpleSentenceWithSpecialCharacter()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("Hello world!","world"));
    }

    [Fact]
    public void Test_RepeatCounter_MatchSimpleSentenceWithSpecialCharacterAndCapitalLetter()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("Hello World!","world"));
    }

    [Fact]
    public void Test_RepeatCounter_NoMatchWhenMatchingWordIsApartOfAnotherWord()
    {
      Assert.Equal(0, RepeatCounter.CountRepeats("HelloWorld!","world"));
    }

    [Fact]
    public void Test_RepeatCounter_MatchComplexLongSentence()
    {
      Assert.Equal(2, RepeatCounter.CountRepeats("Hello world! This is a complex sentence with multiple things to try and trick the counter. Like this: helloworld. What a WORLD.","world"));
    }

    [Fact]
    public void Test_RepeatCounter_MatchWehnInputWordHasACapital()
    {
      Assert.Equal(1, RepeatCounter.CountRepeats("Hello world!","World"));
    }

    [Fact]
    public void Test_RepeatCounter_ForEmptyMatchWord()
    {
      Assert.Equal(0, RepeatCounter.CountRepeats("Hello World",""));
    }    

    [Fact]
    public void Test_RepeatCounter_ForEmptySentence()
    {
      Assert.Equal(0, RepeatCounter.CountRepeats("","world"));
    }    

    [Fact]
    public void Test_RepeatCounter_ForEmptyMatchWordAndSentence()
    {
      Assert.Equal(0, RepeatCounter.CountRepeats("",""));
    }
  }
}