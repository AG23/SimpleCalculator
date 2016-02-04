using System;

namespace SimpleCalculator
{
    internal class InputProcessor
    {
            public void Run()
        {
            while (true)
            {
                int a, b;
                int c;
                Console.WriteLine("enter 1 number ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose action ");
                Console.WriteLine("Example: +,-,/,*,%");
                c = Console.ReadLine()[0];
                Console.WriteLine("enter 2 number ");
                b = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case '+':
                        Console.WriteLine("{0}+{1}={2}", a, b, ((float)a + b));
                        break;
                    case '-':
                        Console.WriteLine("{0}-{1}={2}", a, b, ((float)a - b));
                        break;
                    case '/':
                        Console.WriteLine("{0}/{1}={2}", a, b, ((float)a / b));
                        break;
                    case '*':
                        Console.WriteLine("{0}*{1}={2}", a, b, ((float)a * b));
                        break;
                }
            }
        }
    }
}