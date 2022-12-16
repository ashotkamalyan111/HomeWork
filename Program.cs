using System;

namespace Task25
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 3, 5 => 243 (3^5)
            // 2, 4 => 16 (2^4)
            
            Console.Write("Input A: ");
            var a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input B: ");
            var b = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            
            Console.WriteLine(result);
        }
    }
}




using System;

namespace Task27
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 452 -> 11
            // 82 -> 10
            // 9012 -> 12
            
            var number = Convert.ToInt32(Console.ReadLine()); // 452

            int sum = 0;
            
            // number = 452 => 4 + 5 + 2 = 11 
            // sum = 0
            
            // sum+:    452 -> 452 % 10 = 2 ! // 29 строка  sum = 2
            // number:  452 -> 452 / 10 = 45  // 30 строка  number = 45
            
            // sum+:    45 -> 45 % 10 = 5 !   // 29 строка  sum = 2 + 5 =7
            // number:  45 -> 45 / 10 = 4     // 30 строка  number 4
            
            // sum+:     4 % 10 = 4 !          // 29        sum = 7 + 4 = 11
            // number:   4 / 10 = 0            // 30        number = 0

            do
            {
                sum = sum + number % 10; // 0 + (452 % 10 = 2) = 2  //  2 + (45 % 10 = 5) = 7  //  7 + (4 % 10 = 4) = 11
                number = number / 10; // 452 / 10 = 45
            } while (number > 0);
            
            Console.WriteLine(sum);
        }
    }
}




using System;

namespace Task29
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();

            var length = random.Next(1, 99);

            var array = new int[length];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}