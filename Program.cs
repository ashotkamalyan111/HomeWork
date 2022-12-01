// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Writeline ("Введите два рзличных числа);
ReadLine (x,y);

if x>y
writeline (x "- больше");
writeline (y " - меньше");

else y>x
writeline (y "- больше");
writeline (x "-меньше");



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