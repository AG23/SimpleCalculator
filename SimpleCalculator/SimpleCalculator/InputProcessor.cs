using System;
using System.Linq;

namespace SimpleCalculator
{
    internal class InputProcessor
    {
            public void Run()
        {
            while (true)
            {
                float a, b;
                string c;
                String s;
                s = Console.ReadLine();
                String[] exp = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var operation = s[0];
                var args = s.Skip(1);
                a = float.Parse(exp[1]);
                b = float.Parse(exp[2]);
                c = exp[0];
                switch (c)
                {
                    case "sum":
                        Console.WriteLine("{0}+{1}={2}", a, b, (a + b));
                        break;
                    case "sub":
                        Console.WriteLine("{0}-{1}={2}", a, b, (a - b));
                        break;
                    case "div":
                        Console.WriteLine("{0}/{1}={2}", a, b, (a / b));
                        break;
                    case "mul":
                        Console.WriteLine("{0}*{1}={2}", a, b, (a * b));
                        break;
                }
            }
        }
        }
    }