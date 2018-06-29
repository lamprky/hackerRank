using System;
using System.IO;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/birthday-cake-candles/problem
*/

namespace test.Warmup
{
    public class BirthdayCakeCandles
    {
        private int birthdayCakeCandles(int[] ar)
        {
            int maxNumber = ar.ToList().Max();
            int times = ar.ToList().Where(x => x == maxNumber).Count();

            return times;
        }

        public void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = birthdayCakeCandles(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
