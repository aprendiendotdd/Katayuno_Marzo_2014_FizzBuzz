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
        string expected = "1";
        FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
        string actual = fizzBuzz.Game(1);
        Assert.AreEqual(expected, actual);
      }
    }
}
