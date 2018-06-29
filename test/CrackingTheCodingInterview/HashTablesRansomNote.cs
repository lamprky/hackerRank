using System;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/ctci-ransom-note/problem
*/

namespace test.CrackingTheCodingInterview
{
    public class HashTablesRansomNote
    {
        private bool check(string[] magazine, string[] ransom)
        {
            bool ok = true;

            string[] magazineDist = magazine.Distinct().ToArray();
            string[] ransomDist = ransom.Distinct().ToArray();

            if (magazineDist.Count() < ransomDist.Count())
                ok = false;
            else
            {
                foreach (string item in ransomDist)
                {
                    if (!magazineDist.Contains(item))
                    {
                        ok = false;
                        break;
                    }
                    else
                    {
                        int wordSumOnMag = magazine.Where(x => x == item).Count();
                        int wordSumOnRan = ransom.Where(x => x == item).Count();

                        if (wordSumOnMag < wordSumOnRan)
                        {
                            ok = false;
                            break;
                        }
                    }
                }
            }

            return ok;
        }

        public void Main()
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            bool ok = check(magazine, ransom);
            Console.WriteLine((ok) ? "Yes" : "No");
        }
    }
}
