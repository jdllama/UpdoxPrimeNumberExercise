using System;
using System.Collections.Generic;

namespace UpdoxPrimeNumberExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumberGenerator primeNumberGenerator = new PrimeNumberGenerator();
            List<int> test = new List<int>();
            string results = string.Empty;

            int minValue;
            int maxValue;

            Console.WriteLine("Please provide a starting value.");

            minValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide an ending value.");

            maxValue = Convert.ToInt32(Console.ReadLine());

            test = primeNumberGenerator.generate(minValue, maxValue);
            results = string.Join(", ", test);
            Console.WriteLine();
            Console.WriteLine(String.Format("Between the values {0} and {1} are the following prime numbers:", minValue, maxValue));
            Console.WriteLine(results);

            Console.ReadLine();
        }
    }
}
