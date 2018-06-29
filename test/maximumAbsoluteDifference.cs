using System;
using System.Linq;

class maximumAbsoluteDifference
{
    private int[] elements;
    public int maximumDifference;

    public maximumAbsoluteDifference(int[] a){
        elements = a;
    }

    public void computeDifference(){
        int[] arr2 = elements.Distinct().ToArray();
        Array.Sort(arr2);
        int max = 0;

        if (arr2.Count() != 1)
        {
            max = Math.Abs(arr2[0] - arr2[arr2.Count()- 1]);
        }
       
        maximumDifference = max;
    }


    //static void Main(string[] args)
    //{
    //    Convert.ToInt32(Console.ReadLine());

    //    int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

    //    maximumAbsoluteDifference d = new maximumAbsoluteDifference(a);

    //    d.computeDifference();

    //    Console.Write(d.maximumDifference);
    //}
}