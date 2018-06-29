using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-review-loop/problem
*/

namespace test.DaysOfCoding
{
    public class LetsReview
    {
        public void Main()
        {
            int inputlength = int.Parse(Console.ReadLine());

            string[] inputs = new string[inputlength];

            for (int i = 0; i < inputlength; i++)
            {
                inputs[i] = Console.ReadLine();
            }

            foreach (var word in inputs)
            {
                string first = "";
                string second = "";
                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                        first = first + word[i];
                    else
                        second = second + word[i];
                }

                Console.WriteLine(first + " " + second);
            }
        }
    }
}
