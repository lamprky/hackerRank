using System;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem
*/

namespace test.Warmup
{
    public class maximumAbsDiff
    {
        class MaxAbsoluteDifference
        {
            private int[] elements;
            public int maximumDifference;

            public MaxAbsoluteDifference(int[] a)
            {
                elements = a;
            }

            public void computeDifference()
            {
                int[] arr2 = elements.Distinct().ToArray();
                Array.Sort(arr2);
                int max = 0;

                if (arr2.Count() != 1)
                {
                    max = Math.Abs(arr2[0] - arr2[arr2.Count() - 1]);
                }

                maximumDifference = max;
            }

        }

        public void Main()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            MaxAbsoluteDifference d = new MaxAbsoluteDifference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}