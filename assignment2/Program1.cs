using System;
namespace primeDiv
{
    class solution1
    {
        static void Main(string[] args)
        {
            while (true) 
            {
            //输入部分
                Console.WriteLine("\n请输入正整数:");
                string sNum = Console.ReadLine();
                bool con_flag = int.TryParse(sNum, out int num);//合法性输入检测

                //Console.WriteLine(num);
                //Console.WriteLine(con_flag);

                if (!con_flag) //异常输入处理
                {
                    Console.WriteLine("非法输入!");
                    continue;
                }

             //计算与输出部分
                int record = 0, cycle = num;
                for (int i = 2; (i * i) < cycle; i++)
                {
                    while (num % i == 0)
                    {
                        if (i != record)
                        {
                            Console.Write(i + " ");
                            record = i;
                        }
                        num = num / i;
                    }
                }
                if (num != record && num != 1)
                    Console.Write(num);
            }
        }
    }
}