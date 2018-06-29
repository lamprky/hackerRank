using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-binary-numbers/problem
*/

namespace test.DaysOfCoding
{
    public class BinaryNumbers
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            int pow = -1;

            while (!found)
            {
                pow++;
                if (n <= Math.Pow(2, pow))
                    found = true;
            }
            pow--;

            string binary = "";
            for (int i = pow; i >= 0; i--)
            {
                int isOne = 0;
                if (n / Math.Pow(2, i) >= 1)
                {
                    isOne = 1;
                    n -= (int)Math.Pow(2, i);
                }
                binary += isOne;
            }

            //Console.WriteLine(binary);

            int counter = 0;
            int maxcounter = 0;
            foreach (char c in binary)
            {
                if (c == '1')
                    counter++;
                else
                {
                    if (counter > 0 && maxcounter < counter)
                        maxcounter = counter;

                    counter = 0;
                }

            }
            if (counter > 0 && maxcounter < counter)
                maxcounter = counter;

            Console.WriteLine(maxcounter);
        }
    }
}
