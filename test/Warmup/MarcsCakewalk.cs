using System;
using System.IO;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/marcs-cakewalk/problem
*/

namespace test.Warmup
{
    public class MarcsCakewalk
    {
        private long marcsCakewalk(int[] calorie)
        {
            Array.Sort(calorie);
            Array.Reverse(calorie);

            long sum = 0;
            for (int i = 0; i < calorie.Count(); i++)
            {
                sum = sum + (calorie[i] * (long)Math.Pow(2, i));
            }

            return sum;
        }

        public void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] calorie = Array.ConvertAll(Console.ReadLine().Split(' '), calorieTemp => Convert.ToInt32(calorieTemp));
            long result = marcsCakewalk(calorie);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
