using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class bitwiseAND
{



    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        int[,] data = new int[t,2];

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');

            data[tItr,0] = Convert.ToInt32(nk[0]);
            data[tItr, 1] = Convert.ToInt32(nk[1]);
        }


        for (int i = 0; i < t; i++)
        {
            //List<int> res = new List<int>();

            //for (int j = 1; j <= data[i, 0]; j++)
            //{
            //    for (int k = 2; k <= data[i, 0]; k++)
            //    {
            //        int bitwise = (j & k);

            //        if (bitwise > 0  && !res.Contains(bitwise) && bitwise < data[i, 1])
            //            res.Add(bitwise);
            //    }
            //}
            //Console.WriteLine(res.Count);

            if((data[i, 1] - 1 | data[i, 1]) <= data[i, 0])
                Console.WriteLine(data[i, 1] - 1);
            else
                Console.WriteLine(data[i, 1] - 2);
            

        }
    }
}
