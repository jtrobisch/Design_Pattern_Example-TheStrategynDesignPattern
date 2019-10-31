using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategydesignPattern
{
    public class OperationAdd: Strategy
    {
        public int doOperation(int num1, int num2) {
            return num1 + num2;
        }
    }

    public class OperationSubtract : Strategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }

    public class OperationMultiply : Strategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
