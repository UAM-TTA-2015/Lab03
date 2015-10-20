using System;
using System.Linq;

namespace Calc
{
    public class ArgumentsParser : IArgumentsParser
    {
        public Tuple<Operation, int[]> Parse(string[] args)
        {
            if (args == null || args.Length < 1)
                return null;

            Operation operation;
            if (!Enum.TryParse(args.First(), true, out operation))
                return null;

            var arguments = args.Skip(1).Select(int.Parse).ToArray();

            return Tuple.Create(operation, arguments);
        }
    }
}