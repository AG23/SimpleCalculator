using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    internal class InputProcessor
    {
        public void Run()
        {
            while (true)
            {
                String input;
                input = Console.ReadLine();
                String[] exp = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var operation = exp[0];
                var args = input.Skip(1);
                float firstNumber, secondNumber;
                string action;
                action = exp[0];
                if (action.Length == 3)
                {
                    if (Single.TryParse(exp[1], out firstNumber))
                    {
                        if (Single.TryParse(exp[2], out secondNumber))
                        {
                            OperationBase calculator;
                            switch (action)
                            {
                                case "sum":
                                    calculator = new SumOperation();
                                    calculator.Execute(exp.ToList<String>());
                                    break;
                                case "sub":
                                    calculator = new SubOperation();
                                    calculator.Execute(exp.ToList<String>());
                                    break;
                                case "div":
                                    calculator = new DivOperation();
                                    calculator.Execute(exp.ToList<String>());
                                    break;
                                case "mul":
                                    calculator = new MulOperation();
                                    calculator.Execute(exp.ToList<String>());
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please, check your second number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please, check your first number");
                    }
                }
                else
                {
                    Console.WriteLine("Enter: sum, sub, mul or div");
                }
            }
        }
    }
}
