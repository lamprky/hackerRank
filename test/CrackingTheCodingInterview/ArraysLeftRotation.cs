using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
*/

namespace test.CrackingTheCodingInterview
{
    public class ArraysLeftRotation
    {
        private int[] solve(int[] a, int d)
        {
            List<int> list = a.ToList();

            for (int i = 0; i < d; i++)
            {
                int firstItem = list[0];
                list.RemoveAt(0);
                list.Add(firstItem);
            }
            return list.ToArray();
        }

        public void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = solve(a, d);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
