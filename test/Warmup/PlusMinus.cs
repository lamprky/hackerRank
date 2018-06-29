using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/plus-minus/problem
*/

namespace test.Warmup
{
    public class PlusMinus
    {
        static void plusMinus(int[] arr)
        {
            List<int> array = arr.ToList();
            int count = array.Count();
            int countNeg = array.Where(x => x < 0).Count();
            int countPos = array.Where(x => x > 0).Count();
            int countZer = array.Where(x => x == 0).Count();

            Console.WriteLine((double)countPos / count);
            Console.WriteLine((double)countNeg / count);
            Console.WriteLine((double)countZer / count);
        }

        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }
    }
}
