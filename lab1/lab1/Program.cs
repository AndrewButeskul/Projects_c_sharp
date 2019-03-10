using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, result = 0;
            int selection;
            double c = 0, d = 0, Result = 0;
            
            
            Console.WriteLine("Выберете задание: (для выбора введите номер задания)");

            Console.WriteLine("1. Реализовать функцию вычисления частного двух целых чисел");
            Console.WriteLine("2. Реализовать функцию вычисления произведения двух вещественных чисел");
            Console.WriteLine("3. Реализовать функцию возведения в квадрат суммы двух целых чисел");
            Console.WriteLine("4. Реализовать функцию возведения в квадрат частного двух целых чисел");
            Console.WriteLine("5. Реализовать функцию возведения в квадрат произведения двух вещественных чисел");
            Console.WriteLine("6. Реализовать функцию вычисления произведения двух целых чисел");

            selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("Введите два числа");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b != 0)
                    {
                        result = a / b;
                        Console.WriteLine("Result - " + result);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, деление на ноль невозможно!");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите два числа");
                    c = Convert.ToDouble(Console.ReadLine());
                    d = Convert.ToDouble(Console.ReadLine());
                    Result = c * d;
                    Console.WriteLine("Result - " + Result);
                    break;
                case 3:
                    Console.WriteLine("Введите два числа");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    result = (a + b) * (a + b);
                    Console.WriteLine("Result - " + result);
                    break;
                case 4:
                    Console.WriteLine("Введите два числа");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b != 0)
                    {
                        result = a / b;
                        Console.WriteLine("Result - " + (result*result));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, деление на ноль невозможно!");
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите два числа");
                    c = Convert.ToDouble(Console.ReadLine());
                    d = Convert.ToDouble(Console.ReadLine());
                    Result = c * d;
                    Console.WriteLine("Result - " + Result*Result);
                    break;
                case 6:
                    Console.WriteLine("Введите два числа");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine("Result - " + result);
                    break;
                default:
                    Console.WriteLine("Ошибка! Повторите ввод!");
                    break;
            }
            Console.ReadKey();            
        }
    }
}
