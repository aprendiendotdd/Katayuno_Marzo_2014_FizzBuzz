using NUnit.Framework;

namespace FizzBuzzTest
{
  [TestFixture]
  public class FizzBuzzTest
  {
    private FizzBuzz.FizzBuzz _fizzBuzz;
    [SetUp]
    public void SetUp()
    {
      _fizzBuzz = new FizzBuzz.FizzBuzz();
    }

    [Test]
    public void ReturnStringOneWhenIntegerOne()
    {
      Assert.AreEqual("1", _fizzBuzz.Game(1));
    }

    [Test]
    public void ReturnStringTwoWhenIntegerTwo()
    {
      Assert.AreEqual("2", _fizzBuzz.Game(2));
    }

    [Test]
    public void ReturnStringFourWhenIntegerFour()
    {
      Assert.AreEqual("4", _fizzBuzz.Game(4));
    }

    [Test]
    public void ReturnFizzWhenThree()
    {
      Assert.AreEqual("Fizz", _fizzBuzz.Game(3));
    }

    [TestCase(6, "Fizz")]
    [TestCase(9, "Fizz")]
    public void ReturnFizzWhenDivisibleByThree(int actual, string expected)
    {
      Assert.AreEqual(expected, _fizzBuzz.Game(actual));
    }

    [Test]
    public void ReturnBuzzWhenFive()
    {
      Assert.AreEqual("Buzz", _fizzBuzz.Game(5));
    }

    [TestCase(10, "Buzz")]
    [TestCase(20, "Buzz")]
    public void ReturnBuzzWhenDivisibleByFive(int actual, string expected)
    {
      Assert.AreEqual(expected, _fizzBuzz.Game(actual));
    }

    [TestCase(15, "FizzBuzz")]
    [TestCase(30, "FizzBuzz")]
    public void ReturnFizzBuzzWhenDivisibleByThreeAndFive(int actual, string expected)
    {
      Assert.AreEqual(expected, _fizzBuzz.Game(actual));
    }

    [TestCase(13, "Fizz")]
    [TestCase(23, "Fizz")]
    public void ReturnFizzWhenContainsThree(int actual, string expected)
    {
      Assert.AreEqual(expected, _fizzBuzz.Game(actual));
    }

    [TestCase(52, "Buzz")]
    [TestCase(58, "Buzz")]
    public void ReturnBuzzWhenContainsFive(int actual, string expected)
    {
      Assert.AreEqual(expected, _fizzBuzz.Game(actual));
    }
  }
}
