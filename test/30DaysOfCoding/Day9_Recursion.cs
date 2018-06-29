using System;
using System.IO;

/*
 * Source: https://www.hackerrank.com/challenges/30-recursion/problem
*/

namespace test.DaysOfCoding
{
    public class Recursion
    {
        private int factorial(int n)
        {
            if (n > 1)
                return n * factorial(n - 1);
            else
                return 1;

        }

        public void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
