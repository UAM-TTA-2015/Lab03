using System.Collections.Generic;

namespace Calc
{
    public interface ICalculator
    {
        int Calculate(Operation op, IEnumerable<int> arguments);
    }
}