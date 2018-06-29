using System;
using System.Collections.Generic;

/*
 * Source: https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
*/

namespace test.DaysOfCoding
{
    public class DictionariesMaps
    {
        public void Main()
        {
            string name;
            string pair = "";
            string[] splitPair;

            Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            int length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                pair = Console.ReadLine();
                splitPair = pair.Split(' ');
                phoneBook.Add(splitPair[0], long.Parse(splitPair[1]));
            }

            for (int i = 0; i < length; i++)
            {
                name = Console.ReadLine();
                try
                {
                    Console.WriteLine(name + "=" + phoneBook[name]);
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
