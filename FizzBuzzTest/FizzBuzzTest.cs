using System;
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

      [Test]
      public void ReturnFizzWhenThree()
      {
        var fizzBuzz = new FizzBuzz.FizzBuzz();
        Assert.AreEqual("Fizz", fizzBuzz.Game(3));
      }
      
      [TestCase(6, "Fizz")]
      [TestCase(9, "Fizz")]
      public void ReturnFizzWhenDivisibleByThree(int actual, string expected)
      {
        var fizzBuzz = new FizzBuzz.FizzBuzz();
        Assert.AreEqual(expected, fizzBuzz.Game(actual));
      }
    }
}
