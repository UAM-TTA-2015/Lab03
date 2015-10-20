using System;

namespace Calc
{
    public class Application
    {
        private readonly IArgumentsParser _argumentsParser;
        private readonly ICalculator _calculator;

        public Application(IArgumentsParser argumentsParser, ICalculator calculator)
        {
            _argumentsParser = argumentsParser;
            _calculator = calculator;
        }

        public int Run(string[] args)
        {
            Tuple<Operation, int[]> parseResult = _argumentsParser.Parse(args);
            if (parseResult == null)
                return int.MinValue;

            try
            {
                return _calculator.Calculate(parseResult.Item1, parseResult.Item2);
            }
            catch (ArgumentOutOfRangeException)
            {
                return int.MinValue;
            }
        }
    }
}