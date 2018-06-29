using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-interfaces/problem
*/

namespace test.DaysOfCoding
{
    interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int adv = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    adv += i;
            }
            return adv;
        }
    }

    public class Interfaces
    {
        public void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
