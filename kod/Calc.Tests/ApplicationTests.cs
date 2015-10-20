using System;
using System.Collections.Generic;
using FakeItEasy;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public class ApplicationTests
    {
        private IArgumentsParser _argumentsParser;
        private ICalculator _calculator;
        private Application _sut;

        [SetUp]
        public void SetUp()
        {
            _argumentsParser = A.Fake<IArgumentsParser>();
            _calculator = A.Fake<ICalculator>();
            _sut = new Application(_argumentsParser, _calculator);
        }

        [Test]
        public void Should_Return_IntMin_When_Parser_Returns_Null()
        {
            // arange
            A.CallTo(() => _argumentsParser.Parse(A<string[]>._))
                .Returns(null);

            var expected = int.MinValue;

            var actual = _sut.Run(new[] { "sum" });

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Run_Should_Call_Calculator_With_Sum_Operation_When_First_Arg_Was_sum()
        {
            _sut.Run(new[] { "sum" });

            A.CallTo(() => _calculator.Calculate(Operation.Sum, A<IEnumerable<int>>._))
                .MustHaveHappened();
        }

        [Test]
        public void Should_Return_IntMin_When_Calculator_Thows_Exception()
        {
            // arange
            A.CallTo(() => _calculator.Calculate(A<Operation>._, A<IEnumerable<int>>._))
                .Throws<ArgumentOutOfRangeException>();

            var expected = int.MinValue;

            var actual = _sut.Run(new[] { "sum" });

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(new[] { "sum" }, 12)]
        [TestCase(new[] { "product" }, 17)]
        [TestCase(new[] { "aseq" }, 22)]
        [TestCase(new[] { "ndec" }, 38)]
        public void Run_Should_Return_Calculator_Result(string[] param, int expected)
        {
            A.CallTo(() => _calculator.Calculate(A<Operation>._, A<IEnumerable<int>>._))
                .Returns(expected);

            var actual = _sut.Run(param);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}