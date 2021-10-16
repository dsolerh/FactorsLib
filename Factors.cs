using System;

namespace FactorsLib
{
    public class Factors
    {
        public static bool IsPrime(int number) {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
