using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-more-exceptions/problem
*/

namespace test.DaysOfCoding
{
    class Calculator2
    {
        public int power(int n, int p)
        {
            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            try
            {
                return (int)Math.Pow(n, p);
            }
            catch
            {
                throw;
            }
        }
    }

    public class MoreExceptions
    {
        public void Main()
        {
            Calculator2 myCalculator = new Calculator2();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}
