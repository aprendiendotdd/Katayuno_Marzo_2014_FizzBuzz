﻿namespace FizzBuzz
{
  public class FizzBuzz
  {
    private const string Buzz = "Buzz";
    private const string Fizz = "Fizz";
    private const int Three = 3;
    private const int Five = 5;
    public string Game(int number)
    {
      if (IsDivisible(number, Three) && IsDivisible(number, Five)) return Fizz + Buzz;
      if (IsDivisible(number, Five)) return Buzz;
      return IsDivisible(number, Three) || number.ToString().Contains(Three.ToString()) ? Fizz : number.ToString();
    }

    private static bool IsDivisible(int number, int value)
    {
      return number % value == 0;
    }
  }
}
