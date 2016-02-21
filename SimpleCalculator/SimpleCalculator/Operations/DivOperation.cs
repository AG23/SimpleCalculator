using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class DivOperation : OperationBase
    {
        public override void Execute(List<string> parameters)
        {
            firstNumber = Convert.ToSingle(parameters[1]);
            secondNumber = Convert.ToSingle(parameters[2]);
            Console.WriteLine("{0}/{1}={2}", firstNumber, secondNumber, (firstNumber / secondNumber));
        }
        public static String operatorName()
        {
            return "div";
        }
    }
}
