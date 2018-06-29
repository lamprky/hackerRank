using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-operators/problem
*/

namespace test.DaysOfCoding
{
    public class Operators
    {
        private void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double total = meal_cost + meal_cost * tip_percent / 100d + meal_cost * tax_percent / 100d;
            Console.WriteLine("The total meal cost is " + Math.Round(total) + " dollars.");
        }

        public void Main()
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
