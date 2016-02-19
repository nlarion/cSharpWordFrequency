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
      Assert.Equal(1), repeatCounter());
    }    
    [Fact]
    public void TestReturnLowerCharArray()
    {
      
      Assert.Equal(new char[]{'w','o','r','l','d'}, RepeatCounter.ReturnCharArray>fromString("WORLD"););
    }
  }
}
