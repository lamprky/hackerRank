using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Source: https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
*/

namespace test.Warmup
{
    public class StringsMakingAnagrams
    {
        private void checkList(List<char> listToCheck, List<char> listOther, List<char> lettToRem)
        {

            foreach (char item in listToCheck)
            {
                if (!listOther.Contains(item))
                    lettToRem.Add(item);

                int a = listOther.Where(x => x == item).Count();
                int b = listToCheck.Where(x => x == item).Count();
                if (a != b
                    && lettToRem.Where(x => x == item).Count() == 0)
                {
                    lettToRem.AddRange(Enumerable.Repeat(item, Math.Abs(a - b)));
                }
            }
        }

        public void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            List<char> word1 = a.ToCharArray().ToList();
            List<char> word2 = b.ToCharArray().ToList();
            List<char> lettToRem = new List<char>();

            checkList(word1, word2, lettToRem);
            checkList(word2, word1, lettToRem);

            Console.WriteLine(lettToRem.Count);
        }
    }
}
