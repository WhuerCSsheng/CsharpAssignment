using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace myarray
{
    class solution2
    {
        static void myToInt(string sNum,out int myNum) 
        {
            bool is_a_int = int.TryParse(sNum, out int num);
            if (!is_a_int)
            {
                Console.WriteLine("存在非法的整数输入");
                Environment.Exit(-1);
            }
            myNum = num;
        }
        

        static void stringToDigArr(string sarr, int[] tarr) 
        {
            int n = tarr.Length;
            int[] flags = new int[n - 1];
            int index = 0;

            for (int i = 0; i < sarr.Length - 1; i++)
            {
                if (sarr[i] != ',')
                {
                    continue;
                }
                flags[index] = i;
                index++;
            }

            myToInt((sarr.Substring(0, flags[0])), out int num1);
            tarr[0] = num1;
            myToInt((sarr.Substring(flags[n - 2], sarr.Length - flags[n - 2] - 1)), out int numN);
            tarr[n - 1] = numN;

            for (int i = 1; i < n; i++)
            {
                myToInt(sarr.Substring(flags[i] + 1, flags[i] - flags[i - 1] - 1), out int num);
                tarr[i] = num;
            }
        }


        static int sumOfArr(int[] arr, out int ave)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            ave = sum/arr.Length;
            return sum;
        }


        static void getMax_Min(int[] arr,out int max,out int min)
        {
            max = arr[0];
            min= arr[0];
           for (int i = 1;i < arr.Length;i++) 
            {
                if (arr[i] > max)
                {
                    max= arr[i];
                }
                if (arr[i] < min)
                {
                    min= arr[i];
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("输入数组元素个数n:");
            string sn = Console.ReadLine();
            myToInt(sn, out int n);

            Console.WriteLine(@"以"",""分隔输入足够的整数:");
            string sarr = Console.ReadLine();
            int[] arr = new int[n];
            stringToDigArr(sarr, arr);


            Console.WriteLine(("整型数组元素的和为:"+ sumOfArr(arr,out int ave)));
            Console.WriteLine("整型数组元素的平均值为:" + ave);
            getMax_Min(arr,out int max,out int min);
            Console.WriteLine("整型数组元素的最大值为:" +  max + "  最小值为:" + min);
            

        }
    }
}