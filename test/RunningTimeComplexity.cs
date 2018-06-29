//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//class RunningTimeComplexity
//{
//    static void Main(String[] args)
//    {
//        var numbers = new Dictionary<long, bool?>();

//        int x = Convert.ToInt32(Console.ReadLine());
//        while (x-- > 0)
//        {
//            numbers.Add(long.Parse(Console.ReadLine()), null);
//        }

//        List<long> list = new List<long>(numbers.Keys.Distinct());
//        bool isPrime = true;
//        foreach(long n in list){

//            if (numbers[n] == null)
//            {
//                if (n == 1)
//                {
//                    isPrime = false;
//                }
//                else if (n == 2){
//                    isPrime = true;
//                }
//                else if (n != 2 && n % 2 == 0)
//                {
//                    isPrime = false;
//                }
//                else
//                {
//                    isPrime = true;
//                    long sq = (long)Math.Sqrt(n);
//                    for (int i = 2; i <= sq; i++)
//                    {
//                        if (n % i == 0)
//                        {
//                            isPrime = false;
//                            break;
//                        }                    
//                    }
//                }
//                numbers[n] = isPrime;
//            }

//            if(numbers[n].Value)
//                Console.WriteLine("Prime");
//            else
//                Console.WriteLine("Not prime");

//        }

//    }
//}