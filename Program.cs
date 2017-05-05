using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace fizzbuzz
{
    class Program
    {

        static string FizzBuzz(int number) {
            StringBuilder s = new StringBuilder();
            if(number % 3 == 0) s.Append("Fizz");
            if (number % 5 == 0) s.Append("Buzz");
            return String.IsNullOrEmpty(s.ToString()) ? number.ToString() : s.ToString();
        }

        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).ToList().ForEach(p => Console.WriteLine(FizzBuzz(p)));
        }
    }
}
