using System;
using System.Collections.Generic;
using System.Linq;

namespace Calc
{
    public class Calculator : ICalculator
    {
        public int Calculate(Operation op, IEnumerable<int> arguments)
        {
            switch (op)
            {
                case Operation.Sum:
                    return arguments.Aggregate(0, (a, b) => a + b);
                case Operation.Product:
                    return arguments.Aggregate(1, (a, b) => a * b);
                case Operation.Aseq:
                    return arguments.Aggregate(Tuple.Create<int, int?, int?>(1, null, null), IsArithmeticSequence).Item1;
                case Operation.Ndec:
                    return arguments.Aggregate(Tuple.Create<int, int?>(1, null), IsNonDecreasing).Item1;
                default:
                    throw new ArgumentOutOfRangeException(nameof(op), op, "unknown operation");
            }
        }

        private Tuple<int, int?, int?> IsArithmeticSequence(Tuple<int, int?, int?> prev, int item)
        {
            if (prev.Item1 == 0)
                return prev;
            if (!prev.Item2.HasValue)
                return Tuple.Create<int, int?, int?>(1, item, null);
            if (!prev.Item3.HasValue)
                return Tuple.Create<int, int?, int?>(1, prev.Item2.Value, item);

            var isArithmetic = (prev.Item3.Value - prev.Item2.Value) == (item - prev.Item3.Value);

            return Tuple.Create<int, int?, int?>(isArithmetic ? 1 : 0, prev.Item3.Value, item);
        }

        private Tuple<int, int?> IsNonDecreasing(Tuple<int, int?> prev, int item)
        {
            if (prev.Item1 == 0)
                return prev;
            if (!prev.Item2.HasValue)
                return Tuple.Create<int, int?>(1, item);

            return Tuple.Create<int, int?>(item >= prev.Item2.Value ? 1 : 0, item);
        }
    }
}