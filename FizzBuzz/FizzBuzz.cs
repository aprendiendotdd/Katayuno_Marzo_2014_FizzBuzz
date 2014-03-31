﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
      public string Game(int number)
      {
        if (number % 5 == 0) return "Buzz";
        if (number % 3 == 0) return "Fizz";
        return number.ToString();
      }
    }
}
