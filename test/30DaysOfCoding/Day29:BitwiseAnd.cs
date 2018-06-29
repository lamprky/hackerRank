using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-bitwise-and/problem
*/

namespace test.DaysOfCoding
{
    public class BitwiseAnd
    {
        public void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[,] data = new int[t, 2];

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                data[tItr, 0] = Convert.ToInt32(nk[0]);
                data[tItr, 1] = Convert.ToInt32(nk[1]);
            }


            for (int i = 0; i < t; i++)
            {
                if ((data[i, 1] - 1 | data[i, 1]) <= data[i, 0])
                    Console.WriteLine(data[i, 1] - 1);
                else
                    Console.WriteLine(data[i, 1] - 2);
            }
        }
    }
}