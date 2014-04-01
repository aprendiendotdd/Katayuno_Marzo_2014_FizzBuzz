using System.Collections.Generic;

namespace FizzBuzz
{
  public class FizzBuzz
  {
    private const string Buzz = "Buzz";
    private const string Fizz = "Fizz";
    private const int Three = 3;
    private const int Five = 5;

    public string Game(int number)
    {
      if (IsFizz(number) && IsBuzz(number)) return Fizz + Buzz;
      if (IsBuzz(number)) return Buzz;
      return IsFizz(number) ? Fizz : number.ToString();
    }

    public List<string> ListGame()
    {
      var listFizzBuzz = new List<string>();
      for (var i = 1; i < 101; i++)
        listFizzBuzz.Add(Game(i));

      return listFizzBuzz;
    }

    private static bool IsBuzz(int number)
    {
      return IsDivisible(number, Five) || ContainsValue(number, Five);
    }

    private static bool IsFizz(int number)
    {
      return IsDivisible(number, Three) || ContainsValue(number, Three);
    }

    private static bool ContainsValue(int number, int value)
    {
      return number.ToString().Contains(value.ToString());
    }

    private static bool IsDivisible(int number, int value)
    {
      return number % value == 0;
    }
  }
}
