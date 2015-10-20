using System.Collections.Generic;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public class ArgumentsParserTests
    {
        private IArgumentsParser _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new ArgumentsParser();
        }

        [Test]
        public void Should_Return_Null_For_Null_Arguments()
        {
            var actual = _sut.Parse(null);

            Assert.That(actual, Is.Null);
        }

        [Test]
        public void Should_Return_Null_For_Empty_Arguments()
        {
            var actual = _sut.Parse(new string[] { });

            Assert.That(actual, Is.Null);
        }

        [Test]
        [TestCase(Operation.Sum)]
        [TestCase(Operation.Product)]
        [TestCase(Operation.Aseq)]
        [TestCase(Operation.Ndec)]
        public void Should_Return_Proper_Operation(Operation expected)
        {
            var actual = _sut.Parse(new[] { expected.ToString().ToLower() });

            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Should_Return_Empty_Array_If_Only_Operation_Was_Provided()
        {
            var actual = _sut.Parse(new[] { "sum" });

            Assert.That(actual.Item2, Is.Empty);
        }

        private IEnumerable<IEnumerable<object>> Should_Return_Parsed_String_Array_Sources
        {
            get
            {
                yield return new object[] {
                    new[] { "sum", "0" },
                    new[] { 0 }};
                yield return new object[] {
                    new[] { "sum", "0", "1" },
                    new[] { 0, 1 }};
                yield return new object[] {
                    new[] { "sum", "3", "2", "1" },
                    new[] { 3, 2, 1 }};
            }
        }

        [Test]
        [TestCaseSource(nameof(Should_Return_Parsed_String_Array_Sources))]
        public void Should_Return_Parsed_String_Array(string[] input, int[] expected)
        {
            var actual = _sut.Parse(input);

            Assert.That(actual.Item2, Is.EqualTo(expected));
        }
    }
}