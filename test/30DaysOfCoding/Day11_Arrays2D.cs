using System;

/*
 * Source:https://www.hackerrank.com/challenges/30-2d-arrays/problem
*/

namespace test.DaysOfCoding
{
    public class Arrays2D
    {
        public void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int xPos = 0;
            int yPos = 0;
            int sum = 0;
            int maxsum = 0;

            while (yPos + 2 < arr.Length)
            {
                sum = 0;

                for (int i = xPos; i < xPos + 3; i++)
                {
                    sum += arr[yPos][i];
                }

                sum += arr[yPos + 1][xPos + 1];

                for (int i = xPos; i < xPos + 3; i++)
                {
                    sum += arr[yPos + 2][i];
                }

                if (yPos == 0 && xPos == 0)
                    maxsum = sum;

                if (maxsum < sum)
                    maxsum = sum;

                if (xPos + 3 < arr[yPos].GetLength(0))
                    xPos++;
                else
                {
                    xPos = 0;
                    if (yPos + 3 <= arr.Length)
                        yPos++;
                }
            }

            Console.WriteLine(maxsum);
        }
    }
}
