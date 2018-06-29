using System;
using System.IO;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/compare-the-triplets/problem
*/

namespace test.Warmup
{
    public class CompareTriplets
    {
        private int[] solve(int[] a, int[] b)
        {

            int alicePoints = 0;
            int bobPoints = 0;
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                    alicePoints++;

                if (a[i] < b[i])
                    bobPoints++;
            }

            return new int[] { alicePoints, bobPoints };
        }

        public void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
            int[] result = solve(a, b);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
