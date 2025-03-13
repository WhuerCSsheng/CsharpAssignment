using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
class solution1
{
    abstract class shape
    {
        public abstract double Area { get; }
        public abstract bool selfCheck();
    }

    class Triangle : shape
    {
        private double A1 { get; set; }
        private double A2 { get; set; }
        private double A3 { get; set; }
        public override double Area {  
            get
            {
                if(!selfCheck()) 
                    return -1;
                double p = (A1 + A2 + A3) / 2;
                double s = Math.Sqrt(p * (p - A1) * (p - A2) * (p - A3));
                return s;
            } 
        }
        public Triangle(double a,double b,double c)
        {
            A1 = a;
            A2 = b;
            A3 = c;
            bool is_valid = selfCheck();
            if(!is_valid) 
                Console.WriteLine("创建三角形的参数不合法!");
        }
      public override bool selfCheck() 
        {
            if (A1 <= 0) return false;
            if (A2 <= 0) return false;
            if (A3 <= 0) return false;
            if (A1 + A2 <= A3) return false;
            if (A1 + A3 <= A2) return false;
            if (A2 + A3 <= A1) return false;
            return true;
        }
    }
    class Rectangle : shape
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public override double  Area
        {
            get
            {
                if(!selfCheck()) 
                    return -1;
                return Height*Width ;
            }
        }
        public override bool selfCheck()
        {
            if(Height <= 0) return false;
            if (Width <= 0) return false;
            return true;
        }
        public Rectangle(double w,double h)
        {  
           Width = w;
           Height = h; 
           if(!selfCheck())
                Console.WriteLine("创建长方形的参数不合法!");
        }
    }  
    class Square : shape 
    {
        private double Side;
        public override double Area
        { 
            get 
            {
                if(!selfCheck())
                    return -1;
                return Side*Side; 
            } 
        }
        public override bool selfCheck()
        {
            if(Side <= 0) return false;
            return true;
        }
        public Square(double side)
        {
            Side = side;
            if (!selfCheck())
                Console.WriteLine("创建正方形的参数不合法!");
        }   
    }
    public class program
    {
        public static void Main(string[] args)
        {
            //1.测试代码
            /*
            shape[] shapes = new shape[]
            {
            new Rectangle(2.5,2),
            new Square(1.5),
            new Triangle(3, 4, 5)
            };
            foreach (var shape in shapes)
            {
                Console.Write($"Shape: {shape.GetType().Name}"+" ");
                Console.Write($"Area: {shape.Area}"+"\n");
            }

            shape[] invalid_shapes = new shape[]
            {
                new Rectangle(-1,0.2),
                new Square(0),
                new Triangle(1,2,3)
            };
            foreach (var shape in invalid_shapes)
            {
                Console.Write($"Shape: {shape.GetType().Name}"+" ");
                Console.Write($"Area: {shape.Area}"+"\n");
            }
            */

            //2.随机图形面积和
            Random random = new Random();
            double sum = 0, area = 0;
            for (int i = 1; i < 11; i++) 
            {
                int shapeType = random.Next(0, 3);
                Console.Write($"第{i}个图形:");
                switch (shapeType)
                {
                    case 0:
                        double w = random.Next(1, 10);
                        double h = random.Next(1, 10);
                        Rectangle rect = new Rectangle(w, h);
                        sum += rect.Area;
                        Console.Write($"Shape: Rectangle" + " ");
                        Console.Write($"Area: {rect.Area}" + "\n");
                        break;
                    case 1:
                        double side = random.Next(1, 10);
                        Square s = new Square(side);
                        sum += s.Area;
                        Console.Write($"Shape: Square" + " ");
                        Console.Write($"Area: {s.Area}" + "\n");
                        break;
                    case 2:
                        double a = random.Next(1, 10);
                        double b = random.Next(1, 10);
                        double c = random.Next(1, 10);
                        while (a + b <= c || a + c <= b || b + c <= a)
                        {
                            a = random.Next(1, 10);
                            b = random.Next(1, 10);
                            c = random.Next(1, 10);
                        }
                        Triangle tria = new Triangle(a, b, c);
                        sum += tria.Area;
                        Console.Write($"Shape: Triangle" + " ");
                        Console.Write($"Area: {tria.Area}" + "\n");
                        break;
                }
            }
            Console.WriteLine($"随机生成的十个图形的面积和为:{sum}");
        }
    }

}