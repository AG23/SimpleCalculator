using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public abstract class OperationBase
    {
        public abstract void Execute(List<string> parameters);
        float firstNumber, secondNumber;
    }
}
