using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/grading/problem
*/

namespace test.Warmup
{
    public class GradingStudents
    {
        static int[] gradingStudents(int[] grades)
        {

            List<int> roundedGrades = new List<int>();
            for (int i = 0; i < grades.Count(); i++)
            {
                if (grades[i] < 38)
                    roundedGrades.Add(grades[i]);
                else
                {
                    int dekades = (int)(grades[i] / 5);
                    if (((dekades + 1) * 5) - grades[i] < 3)
                        roundedGrades.Add((dekades + 1) * 5);
                    else
                        roundedGrades.Add(grades[i]);
                }
            }
            return roundedGrades.ToArray();
        }

        public void Main()
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);

            tw.WriteLine(string.Join("\n", result));

            tw.Flush();
            tw.Close();
        }
    }
}
