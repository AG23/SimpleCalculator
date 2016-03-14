﻿using System;
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
                string action;
                action = exp[0];
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
        }
    }
}
