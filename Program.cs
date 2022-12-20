using System;

namespace Task34
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var length = random.Next(1, 100);

            var array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 999);
            }

            int count = 0; // счетчик
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]); // вывели в консоль

                if (array[i] % 2 == 0) // проверяем, что число делится на 2 без остатка
                {
                    count++; //count = count + 1;
                }
            }
            
            Console.WriteLine("Число четных чисел: " + count);
        }
    }
}





using System;

namespace Task35
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[123];

            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(200);
            }

            int count = 0; // счетчик
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                if (array[i] > 10 && array[i] < 99)
                {
                    count++;
                }
            }
            
            Console.WriteLine($"Чисел от 10 до 99: {count}");
        }
    }
}




using System;

namespace Task36
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();

            var length = random.Next(1, 100);

            var array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(999);
            }

            // способ 1: проверяем в общем цикле
            
            int sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine($"Summ1: {sum}");
            
            // способ 2: пропускаем четные (второй, четвертый, шестой)
            
            int sum2 = 0;
            
            for (int i = 0; i < array.Length; i+=2)
            {
                sum2 += array[i];
            }
            
            Console.WriteLine($"Summ2: {sum}");
        }
    }
}



using System;

namespace Task37
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задача 37: Найдите произведение пар чисел в одномерном массиве.
            //Парой считаем первый и последний элемент, второй и предпоследний
            //и т.д. Результат запишите в новом массиве.
            
            // { 3, 8, 5, 4, 2 } -> { 3 * 2, 8 * 4, 5 } -> 6, 32, 5

            var array = new[] { 3, 8, 5, 4, 2 };

            var lenght = array.Length / 2 + array.Length % 2;

            var result = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                if (i != array.Length - 1 - i)
                {
                    result[i] = array[i] * array[array.Length - 1 - i];
                }
                else
                {
                    result[i] = array[i];
                }
            }

            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
        }
    }
}




using System;

namespace Task38
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Задайте массив вещественных чисел.
            // Найдите разницу между максимальным и минимальным элементов массива.
            
            var random = new Random();

            var length = random.Next(1, 100);

            var array = new int[length];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 999);
            }

            var min = array[0]; // исходное минимальное значение
            var max = array[0]; // исходное максимальное значение

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine(max - min);
        }
    }
} 