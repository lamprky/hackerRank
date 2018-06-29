using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/problem
*/

namespace test.DaysOfCoding
{
    public class Exceptions
    {
        public void Main(String[] args)
        {
            string S = Console.ReadLine();

            try
            {
                int result = int.Parse(S);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
