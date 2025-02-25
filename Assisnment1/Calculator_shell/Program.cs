using System;
namespace myCalculator{ 
    class program
    {
        static void Main(string[] args)
        {
            //引导与输入
            Console.WriteLine(@"Please input your binary expression(+-*/):");
            string inpExp = Console.ReadLine();

            //初始化
            int i = 0, opNum = 0, indexA = 0, indexB = 0, index = 0;
               /*
                * opNum为运算符号编号
                *indexA为第一个输入的数的位数(有负号包括负号)，indexB同理为第二个数的
                *i用于循环记录
                */
            double a = 1;double b = 1;double expRes = 0;//expRes = a (operation) b

            //分解输入处理
            while (inpExp != null && i<inpExp.Length)
            {
                if (inpExp[i] < 48 || inpExp[i] > 57) 
                {
                    //负号 or 减号特殊处理
                    if (inpExp[i] == '-')
                    {
                        if (i == 0|| (inpExp[i - 1] < 48 || inpExp[i - 1] > 57))
                        {
                            index++;
                            i++;
                            continue;
                        }
                        else
                            opNum = 2;
                    }
                    else if (inpExp[i] == '+')
                        opNum = 1;
                    else if (inpExp[i] == '*')
                        opNum = 3;
                    else if (inpExp[i] == '/')
                        opNum = 4; 
                    else if (inpExp[i]=='.')
                    {
                        index++;
                        i++;
                        continue;
                    }
          
                    indexA = index;
                    index = 0;
                } 
                else
                    index++;
                i++;
            }
            indexB = index;
            string sA = inpExp.Substring(0,indexA); 
            string sB = inpExp.Substring(indexA+1,inpExp.Length-indexA-1);

            //处理这两个数，将它们从字符串转换成数的相关类型
            a = Convert.ToDouble(sA);
            b = Convert.ToDouble(sB);

            //得出运算结果(四则)
            switch (opNum)
            {
                case 1:
                    expRes = a + b;
                    break;
                case 2:
                    expRes = a - b;
                    break;
                case 3:
                    expRes = a * b;
                    break;
                case 4:
                    if(b!=0)
                        expRes = a / b;
                    else 
                    {
                        Console.WriteLine("Alarming:Invalid Divisor!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Alarming:Invalid Expression!");
                    return;  
            }
            Console.WriteLine($"{expRes}");
        }
    }
}

