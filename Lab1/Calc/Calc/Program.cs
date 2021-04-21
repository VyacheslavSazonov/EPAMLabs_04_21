using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double FirstArgument, SecondArgument;
                string Operator;

                try
                {
                    Console.WriteLine("Введите первый аргумент");
                    FirstArgument = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите второй аргумент");
                    SecondArgument = Convert.ToDouble(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Неверное число");
                    continue;
                }
                Console.WriteLine("Введите оператор (+ - / *)");
                Operator = (Console.ReadLine());


                switch (Operator)
                {
                    
                    case "+":
                            Console.WriteLine(FirstArgument + SecondArgument);
                            break;
                    case "-":
                            Console.WriteLine(FirstArgument - SecondArgument);
                            break;
                    case "*":
                            Console.WriteLine(FirstArgument * SecondArgument);
                            break;
                    case "/":
                        if
                            (SecondArgument == 0)
                                Console.WriteLine("Деление на 0 невозможно");
                            else
                                Console.WriteLine(FirstArgument / SecondArgument);
                            break;
                    default: Console.WriteLine("Неверное действие");
                        break;
                }
            }

        }
    }
}