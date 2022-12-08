Console.WriteLine("Введите первое число: ");
            int num_A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num_B = Convert.ToInt32(Console.ReadLine());

            if (num_A > num_B)
            {
                Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
            }
            else
            {
                Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
            }
            break;




Readline(a,b,c);
Console.WriteLine("Введите 3 числа:");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int num_3 = Convert.ToInt32(Console.ReadLine());

            int max = num_1;

            if (num_2 > max)
            {
                max = num_2;
            }

            if (num_3 > max)
            {
                max = num_3;
            }

            Console.WriteLine("Наибольшее из введённых чисел -> " + max);
            break;

    


    Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
            }
            



int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }






            // вторая домашка


            using System;

namespace Task10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Задача 456 -> 5

            int number = Convert.ToInt32(Console.ReadLine());
            var value1 = (number % 100); // 456 -> 56
            var value2 = value1 / 10; // 56 -> 5

            Console.WriteLine(value2);
            Console.ReadKey();
        }
    }
}






using System;

namespace Task13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 456 -> 6
            // 782 -> 2
            // 918 ->
            
            var input = Convert.ToInt32(Console.ReadLine());

            if (input < 100)
            {
                Console.WriteLine("третьей цифры нет");
            }
            else
            {
                Console.WriteLine(input % 10);
            }

            Console.ReadKey();
        }
    }
}





using System;

namespace Task15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1 -> нет
            // 6 -> да
            
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 1 || input > 7)
            {
                Console.WriteLine("ошибка ввода");
            }
            else
            {
                if (input > 5)
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