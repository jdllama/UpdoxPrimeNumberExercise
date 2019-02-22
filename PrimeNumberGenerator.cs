using System;
using System.Collections.Generic;

namespace UpdoxPrimeNumberExercise
{
    class PrimeNumberGenerator
    {
        private Boolean isPrime(int value)
        {
            //Quick and easy math short cuts
            //If it's 1 or lower, it's not prime
            if (value <= 1)
            {
                return false;
            }
            //2 is prime
            if(value == 2)
            {
                return true;
            }
            //divisible by two is NOT prime
            if(value % 2 == 0)
            {
                return false;
            }

            //we only need to do the value in half; if it passes through the loop with no issues,
            //then we know for certain it has to be prime.
            var limit = value / 2;

            for (int i = 3; i <= limit; i += 2)
            {
                if(value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> generate(int startingValue, int endingValue)
        {
            List<int> primeNumbers = new List<int>();

            //We do this just in case the numbers are not provided in the correct order
            int tempStart = startingValue;
            int tempEnd = endingValue;
            tempStart = Math.Min(startingValue, endingValue);
            tempEnd = Math.Max(startingValue, endingValue);

            for (var i = tempStart; i <= tempEnd; i++)
            {
                if (isPrime(i) == true)
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }

        
    }
}
