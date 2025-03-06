using System;
using System.Buffers;

namespace SOE //Sieve of Eratosthenes 埃筛
{
    class solution3
    {
        static void findPrimeWithin100()
        {
            bool[] arr = new bool[99];
            for (int i = 0; i < 99; i++)
            {
                if (!arr[i])
                {
                    Console.Write((i + 2) + " ");
                    int times = 1;//将所寻出的素数放大的倍率
                    while (times * (i + 2) <= 100) //100以内，超出不考虑
                    {
                        arr[(i + 2) * times - 2] = true;//已排除的数（用数组下标指示）
                        times++;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            findPrimeWithin100();
        }
    }

}