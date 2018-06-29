using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-conditional-statements/problem
*/

namespace test.DaysOfCoding
{
    public class ConditionalStatements
    {
        public void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1)
                Console.WriteLine("Weird");
            else if (N >= 2 && N <= 5)
                Console.WriteLine("Not Weird");
            else if (N >= 6 && N <= 20)
                Console.WriteLine("Weird");
            else if (N > 20)
                Console.WriteLine("Not Weird");

        }
    }
}
