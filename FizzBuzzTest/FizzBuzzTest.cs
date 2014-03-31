﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzTest
{
  [TestFixture]
    public class FizzBuzzTest
    {
      [Test]
      public void ReturnStringOneWhenIntegerOne()
      {
        var fizzBuzz = new FizzBuzz.FizzBuzz();
        Assert.AreEqual("1", fizzBuzz.Game(1));
      }

      [Test]
      public void ReturnStringTwoWhenIntegerTwo()
      {
        var fizzBuzz = new FizzBuzz.FizzBuzz();
        Assert.AreEqual("2", fizzBuzz.Game(2));
      }

      [Test]
      public void ReturnStringFourWhenIntegerFour()
      {
        var fizzBuzz = new FizzBuzz.FizzBuzz();
        Assert.AreEqual("4", fizzBuzz.Game(4));
      }
    }
}
