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
                var operation = input[0];
                var args = input.Skip(1);
                float firstNumber, secondNumber;
                firstNumber = float.Parse(exp[1]);
                secondNumber = float.Parse(exp[2]);

                OperationBase Sum = new SumOperation();
                OperationBase Sub = new SubOperation();
                OperationBase Mul = new MulOperation();
                OperationBase Div = new DivOperation();

                string action;
                action = exp[0];
                switch (action)
                {
                    case "sum":
                        Sum.Execute(List < string > parameters);
                        break;
                    case "sub":
                        Sub.Execute(List < string > parameters);
                        break;
                    case "div":
                        Div.Execute(List < string > parameters);
                        break;
                    case "mul":
                        Mul.Execute(List < string > parameters);
                        break;
                }
            }
        }
    }
}