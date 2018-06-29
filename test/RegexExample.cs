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

class DbModel{
    public string firstname { get; set; }
    public string emailID { get; set; }
    public bool matchRegex { get; set; }
}
class RegexExample
{
    
    //static void Main(string[] args)
    //{
    //    int N = Convert.ToInt32(Console.ReadLine());
    //    List<DbModel> array = new List<DbModel>();

    //    for (int NItr = 0; NItr < N; NItr++)
    //    {
    //        string[] firstNameEmailID = Console.ReadLine().Split(' ');

    //        Model model = new Model();
    //        model.firstname = firstNameEmailID[0];
    //        model.emailID = firstNameEmailID[1];

    //        array.Add(model);

    //    }

    //    printGmailsOrdered(array);

    //}

    private static void printGmailsOrdered(List<DbModel> array)
    {
        Regex regex = new Regex(@".*@gmail\.com$");

        foreach(DbModel m in array){
            Match match = regex.Match(m.emailID);
            m.matchRegex = match.Success;
        }

        Console.WriteLine(string.Join("\n", array.Where(x=>x.matchRegex).OrderBy(x=>x.firstname).Select(x=>x.firstname)));

    }
}
