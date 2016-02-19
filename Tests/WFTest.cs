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
      Assert.Equal(0, repeatCounter.CountRepeats());
    }    
    [Fact]
    public void TestReturnLowerCharArray()
    {
      
      Assert.Equal(new char[]{'w','o','r','l','d'}, RepeatCounter.ReturnLowerCharArrayFromString("WORLD"));
    }
  }
}