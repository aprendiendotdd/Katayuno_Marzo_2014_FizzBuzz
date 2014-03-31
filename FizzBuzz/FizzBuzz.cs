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
      if ((IsDivisible(number, Three) || ContainsValue(number, Three)) && (IsDivisible(number, Five) || ContainsValue(number, Five))) return Fizz + Buzz;
      if (IsDivisible(number, Five) || ContainsValue(number, Five)) return Buzz;
      return IsDivisible(number, Three) || ContainsValue(number, Three) ? Fizz : number.ToString();
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
