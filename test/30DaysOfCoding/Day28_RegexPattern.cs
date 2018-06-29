using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-regex-patterns/problem 
*/

namespace test.DaysOfCoding
{
    class dbModel
    {
        public string firstname { get; set; }
        public string emailID { get; set; }
        public bool matchRegex { get; set; }
    }

    public class RegexPatern
    {
        public void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<dbModel> array = new List<dbModel>();

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                dbModel model = new dbModel();
                model.firstname = firstNameEmailID[0];
                model.emailID = firstNameEmailID[1];

                array.Add(model);
            }

            printGmailsOrdered(array);

        }

        private void printGmailsOrdered(List<dbModel> array)
        {
            Regex regex = new Regex(@".*@gmail\.com$");

            foreach (dbModel m in array)
            {
                Match match = regex.Match(m.emailID);
                m.matchRegex = match.Success;
            }

            Console.WriteLine(string.Join("\n", array.Where(x => x.matchRegex).OrderBy(x => x.firstname).Select(x => x.firstname)));
        }
    }
}