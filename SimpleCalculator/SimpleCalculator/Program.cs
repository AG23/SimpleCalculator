using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new InputProcessor();
            processor.Run(); 
        }
    }

    internal class InputProcessor
    {
        public void Run()
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
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}