using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    public interface IArgumentsParser
    {
        Tuple<Operation, int[]> Parse(string[] args);
    }
}