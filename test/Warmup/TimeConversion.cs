using System;
using System.IO;

/*
 * Source: https://www.hackerrank.com/challenges/time-conversion/problem
*/

namespace test.Warmup
{
    public class TimeConversion
    {
        private string timeConversion(string s)
        {
            string[] stringTime = s.Substring(0, s.Length - 2).Split(':');
            int hour = int.Parse(stringTime[0]);

            if (s.Substring(s.Length - 2) == "PM" && hour != 12)
                hour += 12;
            if (s.Substring(s.Length - 2) == "AM" && hour == 12)
                hour -= 12;

            return ((hour < 10) ? "0" + hour.ToString() : hour.ToString()) + ":" + stringTime[1] + ":" + stringTime[2];
        }

        public void Main()
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();
            string result = timeConversion(s);

            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
        }
    }
}
