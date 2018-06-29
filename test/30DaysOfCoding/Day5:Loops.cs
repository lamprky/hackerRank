using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-loops/problem
*/

namespace test.DaysOfCoding
{
    public class Loops
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + n * i);
            }
        }
    }
}
