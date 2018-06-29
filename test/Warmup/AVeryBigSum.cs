using System;
using System.IO;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/a-very-big-sum/problem
*/

namespace test.Warmup
{
    public class AVeryBigSum
    {
        private long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            for (long i = 0; i < ar.Count(); i++)
            {
                sum = sum + ar[i];
            }
            return sum;
        }

        public void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
