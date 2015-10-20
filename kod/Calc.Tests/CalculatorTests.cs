using System;
using System.Linq;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public partial class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
            _sut = new Calculator();
        }

        private ICalculator _sut;

        [Test]
        public void Should_Throw_Exception_When_Unsupported_Operation_Is_Given()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.Calculate((Operation)10, Enumerable.Empty<int>()));
        }

        [Test]
        public void Should_Throw_Exception_When_Unsupported_Operation_Is_Given_With_Proper_ParamName()
        {
            string exprectedParamName = "op";
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _sut.Calculate((Operation)10, Enumerable.Empty<int>()));
            Assert.That(exception.ParamName, Is.EqualTo(exprectedParamName));
        }
    }
}