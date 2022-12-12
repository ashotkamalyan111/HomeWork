using System;

namespace Task21
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 12821 -> да
            // 14212 -> нет
            
            int input = Convert.ToInt32(Console.ReadLine());

            int value1 = input / 10000;
            int value5 = input % 10;

            int value2 = (input % 10000) / 1000;
            int value4 = (input % 100) / 10;

            if (value1 == value5 && value2 == value4)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
        }
    }
}
using System;

namespace Task21_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input Xa: ");
            double xa = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input Ya: ");
            double ya = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input Za: ");
            double za = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input Xb: ");
            double xb = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input Yb: ");
            double yb = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input Zb: ");
            double zb = Convert.ToDouble(Console.ReadLine());
            
            double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
            
            Console.WriteLine(distance);
        }
    }
using System;

namespace Task23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i * i * i}, ");
            }
        }
    }
}
 
