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
                firstNumber = float.Parse(exp[1]);
                secondNumber = float.Parse(exp[2]);

                OperationBase calculator;

                if (operation == SumOperation.operatorName())
                {
                    calculator = new SumOperation();
                }
                else if (operation == SubOperation.operatorName())
                {
                    calculator = new SubOperation();
                }
                else if (operation == MulOperation.operatorName())
                {
                    calculator = new MulOperation();
                }
                else if (operation == DivOperation.operatorName())
                {
                    calculator = new DivOperation();
                }
                else
                {
                    Console.WriteLine("error");
                    break;
                }
                calculator.Execute(exp.ToList<String>());
            }
        }
    }
}