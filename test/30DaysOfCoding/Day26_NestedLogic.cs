using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

/*
 * Source: https://www.hackerrank.com/challenges/30-nested-logic/problem
*/

namespace test.DaysOfCoding
{
    public class NestedLogic
    {
        public void Main()
        {
            string a = Console.ReadLine();
            string e = Console.ReadLine();

            int[] ex = Array.ConvertAll(e.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] ac = Array.ConvertAll(a.Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            DateTime expected = ConvertStringToDateTime(ex);
            DateTime actual = ConvertStringToDateTime(ac);

            int fee = CalculateFee(expected, actual);
            Console.WriteLine(fee);
        }

        private int CalculateFee(DateTime expected, DateTime actual)
        {
            int fee = 0;
            if (actual > expected)
            {
                if (actual.Year == expected.Year && actual.Month == expected.Month)
                    fee = (actual.Day - expected.Day) * 15;
                else if (actual.Year == expected.Year)
                    fee = (actual.Month - expected.Month) * 500;
                else
                    fee = 10000;
            }

            return fee;
        }

        private DateTime ConvertStringToDateTime(int[] input)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            provider = new CultureInfo("en-US");
            string format = "dd/MM/yyyy";

            string dateString = input[0].ToString().PadLeft(2, '0') + "/"
                                      + input[1].ToString().PadLeft(2, '0') + "/"
                                      + input[2].ToString().PadLeft(4, '0');

            DateTime output = DateTime.ParseExact(dateString, format, provider);
            return output;
        }
    }
}