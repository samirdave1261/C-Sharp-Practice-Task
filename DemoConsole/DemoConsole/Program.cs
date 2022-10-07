using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Solution //======> Basic Practicle OF C# [Samir Dave] <======//
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==>Enter Your Choise::");
            int choise = Convert.ToInt32(Console.ReadLine());


            if (choise == 1)//======> array Sorting======>
            {

                int[] arry = { 1, 2, 3, 5, 6, 6 };
                Array.Sort(arry);
                Console.WriteLine("===Ascending===");
                foreach (int item in arry)
                {
                    Console.WriteLine("SortArray" + item);
                }
                Array.Reverse(arry);
                Console.WriteLine("===Descending===");
                foreach (int item in arry)
                {
                    Console.WriteLine("SortArray" + item);
                }
            }
            else if(choise == 2) //======> Give Duplicate value Count ======>
            {
                int[] arry = { 1, 2, 3, 5, 3 };

                var test1 = arry.GroupBy(x => x).Select(x => x.Count()).ToList();
                var demo = test1.Max(y => y);

                Console.WriteLine(demo);

            }
            else if(choise== 3) //===> Positive Min-max sum.===>
            {
                //------------First way--------------//
                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
                miniMaxSum(arr);

                //------------Second way--------------//
                long[] A = { 1, 3, 5, 7, 9 };
                long max = A.Sum();
                long min = max;

                min -= A.Min();
                max -= A.Max();
                Console.WriteLine($"=== Min-Max value is ===> {min} {max}");
            }
            else if (choise == 4)//======> Convert Date format 12 hour to 24 hour ======>
            {
                string date = "01:01:00PM";
                DateTime d = DateTime.Parse(date);
                Console.WriteLine("=== 24 Date Format Converted ===>" + d.ToString("HH:mm:ss"));
            }
            else if(choise == 5)
            {
                string test = "ABCDEFGH";
                char[] array = test.ToCharArray();
                Array.Reverse(array);
                Console.WriteLine(array);
            }
            Console.ReadKey();
        }

        public static void miniMaxSum(List<int> arr)//===> Positive Min-Max Sum.===>
        {
            arr.Sort();
            int Min = 0, Max = 0;
            for (int i = 1; i < arr.Count; i++)
            {
                Max += arr[i];
                Min += arr[i - 1];
            }

            Console.WriteLine("=== Min-Max value is ===>"+Min + " " + Max);

        }
    }

}