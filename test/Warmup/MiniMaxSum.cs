using System;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/mini-max-sum/problem
*/

namespace test.Warmup
{
    public class MiniMaxSum
    {
        private void miniMaxSum(long[] arr)
        {
            long minsum = arr.Sum() - arr[0];
            long maxsum = arr.Sum() - arr[0];

            long sum = 0;
            for (long i = 0; i < arr.Length; i++)
            {
                sum = 0;
                for (long j = 0; j < arr.Length; j++)
                {
                    if (j != i)
                        sum += arr[j];
                }

                if (sum > maxsum)
                    maxsum = sum;
                if (sum < minsum)
                    minsum = sum;
            }

            Console.WriteLine(minsum + " " + maxsum);

        }

        public void Main()
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            miniMaxSum(arr);
        }
    }
}
