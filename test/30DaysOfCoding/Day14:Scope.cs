using System;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/30-scope/problem
*/

namespace test.DaysOfCoding
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
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

                //for (int i = 0; i < elements.Count() - 1; i++)
                //{
                //    for (int j = i + 1; j < elements.Count(); j++)
                //    {
                //        int difference = Math.Abs(arr2[i] - arr2[j]);

                //        if (max < difference)
                //            max = difference;
                //    }
                //}
            }

            maximumDifference = max;
        }
    }

    public class Scope
    {
        public void Main()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}