using System;
using System.Collections.Generic;

namespace FactorsLib
{
    public class Factors
    {
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] PrimeFactors(int number)
        {
            if (IsPrime(number))
            {
                return new int[] { number };
            }
            List<int> primeFactors = new List<int>();

            while (number != 1)
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0 && IsPrime(i))
                    {
                        primeFactors.Add(i);
                        number /= i;
                        break;
                    }
                }
            }

            return primeFactors.ToArray();
        }
    }
}
