using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветственное сообщение.");
            double a;
            double b;
            double total;
            bool check = false;
            char oper;
            while (check == false)
            {
                Console.WriteLine("Введите первое число:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = Convert.ToDouble(Console.ReadLine());
                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
                    Console.WriteLine("Измениние 1.");
                    Console.WriteLine("Измениние 2.");
                    /*
                    Console.WriteLine("Продолжить?Y/N.");
                    if (Console.ReadKey().Key == ConsoleKey.N)
                    {
                        Environment.Exit(0);
                    }
                    */


                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
                    Console.WriteLine("Измениние 1.");
                    Console.WriteLine("Измениние 2.");
                    Console.WriteLine("Продолжить?Y/N.");
                    /*
                    Console.WriteLine("Продолжить?Y/N.");
                    if (Console.ReadKey().Key == ConsoleKey.N)
                    {
                        Environment.Exit(0);
                    }
                    */


                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
                    Console.WriteLine("Измениние 1.");
                    Console.WriteLine("Измениние 2.");
                    Console.WriteLine("Продолжить?Y/N.");
                    /*
                    Console.WriteLine("Продолжить?Y/N.");
                    if (Console.ReadKey().Key == ConsoleKey.N)
                    {
                        Environment.Exit(0);
                    }
                    */


                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                    Console.WriteLine("Измениние 1.");
                    Console.WriteLine("Измениние 2.");
                    Console.WriteLine("Продолжить?Y/N.");
                    /*
                     Console.WriteLine("Продолжить?Y/N.");
                     if (Console.ReadKey().Key == ConsoleKey.N)
                     {
                         Environment.Exit(0);
                     }
                     */
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
            }
        }
    }
}
