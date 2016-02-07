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
                float firstNumber, secondNumber;
                string action;
                String input;
                try
                {
                    input = Console.ReadLine();
                    String[] exp = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var operation = input[0];
                    var args = input.Skip(1);
                    firstNumber = float.Parse(exp[1]);
                    secondNumber = float.Parse(exp[2]);
                    action = exp[0];
                    switch (action)
                    {
                        case "sum":
                            Console.WriteLine("{0}+{1}={2}", firstNumber, secondNumber, (firstNumber + secondNumber));
                            break;
                        case "sub":
                            Console.WriteLine("{0}-{1}={2}", firstNumber, secondNumber, (firstNumber - secondNumber));
                            break;
                        case "div":
                            Console.WriteLine("{0}/{1}={2}", firstNumber, secondNumber, (firstNumber / secondNumber));
                            break;
                        case "mul":
                            Console.WriteLine("{0}*{1}={2}", firstNumber, secondNumber, (firstNumber * secondNumber));
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please try again");
                }
            }
        }
    }
}