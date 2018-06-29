using System;
using System.IO;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/simple-array-sum/problem
*/

namespace test.Warmup
{
    public class SimpleArraySum
    {
        private int simpleArraySum(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Count(); i++)
            {
                sum = sum + ar[i];
            }

            return sum;
        }

        public void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
