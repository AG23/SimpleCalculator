using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class SumOperation : OperationBase
    {
        
           public override void Execute(List<string> parameters)
        {
Console.WriteLine("{0}+{1}={2}", firstNumber, secondNumber, (firstNumber + secondNumber));
        }
        }
        
    }
