using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/30-arrays/problem
*/

namespace test.DaysOfCoding
{
    public class Arrays
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            List<int> array = arr.ToList();
            array.Reverse();

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
