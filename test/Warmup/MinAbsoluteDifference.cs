using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/*
 * Source: https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem
*/

namespace test.Warmup
{
    class minimumAbsoluteDifference
    {
        private int computeDifference(int n, int[] arr)
        {
            int[] arr2 = arr.Distinct().ToArray();
            Array.Sort(arr2);
            int min = 0;

            if (arr2.Count() == arr.Count())
            {
                min = Math.Abs(arr2[0] - arr2[1]);
                for (int i = 0; i < n - 1; i++)
                {
                    if (min == 1)
                        break;

                    int difference = Math.Abs(arr2[i] - arr2[i + 1]);

                    if (min > difference)
                        min = difference;
                }
            }
            else
            {
                //there are same numbers which difference is 0
                min = 0;
            }
            return min;
        }

        public void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = computeDifference(n, arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}