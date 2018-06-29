using System;
using System.Collections.Generic;
using System.IO;

/*
 * Source: https://www.hackerrank.com/challenges/30-data-types/problem
*/

namespace test.DaysOfCoding
{
    public class DataTypes
    {
        public void Main()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int myInt;
            double myDouble;
            string myString;

            // Read and save an integer, double, and String to your variables.
            myInt = int.Parse(Console.ReadLine());
            myDouble = double.Parse(Console.ReadLine());
            myString = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(myInt + i);

            // Print the sum of the double variables on a new line.
            double myDoubleSum = (double)(myDouble + d);
            Console.WriteLine(String.Format("{0:F1}", Math.Round(myDoubleSum, 1)));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + myString);
        }
    }
}
