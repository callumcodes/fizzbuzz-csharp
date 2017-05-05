using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace fizzbuzz
{
    class Program
    {
        static string FizzBuzz(int num) 
        {
            StringBuilder sb = new StringBuilder();
            if(num % 3 == 0) sb.Append("Fizz");
            if(num % 5 == 0) sb.Append("Buzz");
            return String.IsNullOrEmpty(sb.ToString()) ? num.ToString() : sb.ToString();
        }

        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).ToList().ForEach(p => Console.WriteLine(FizzBuzz(p)));
        }
    }
}
