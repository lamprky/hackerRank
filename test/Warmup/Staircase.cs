using System;

/*
 * Source: https://www.hackerrank.com/challenges/staircase/problem
*/

namespace test.Warmup
{
    public class Staircase
    {
        private void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("".PadRight(i, '#').PadLeft(n, ' '));
            }

        }

        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
