using System.Collections.Generic;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public partial class CalculatorTests
    {
        [Test]
        public void Calculate_Aseq_Returns_One_When_There_Are_No_Arguments()
        {
            int expected = 1;

            int actual = _sut.Calculate(Operation.Aseq, new int[] { });

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Aseq_Returns_One_When_There_Is_Only_One_Argument()
        {
            int expected = 1;

            int actual = _sut.Calculate(Operation.Aseq, new[] { 5 });

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Aseq_Returns_One_When_There_Are_Two_Arguments()
        {
            int expected = 1;

            int actual = _sut.Calculate(Operation.Aseq, new[] { 5, -3 });

            Assert.That(actual, Is.EqualTo(expected));
        }

        private IEnumerable<int[]> Calculate_Aseq_Returns_One_For_Arithmetic_Sequence_Sources
        {
            get
            {
                yield return new[] { 10, 7, 4, 1, -2, -5, -8 };
                yield return new[] { 42, 42, 42, 42, 42 };
                yield return new[] { 1, 2, 3 };
            }
        }

        [Test]
        [TestCaseSource(nameof(Calculate_Aseq_Returns_One_For_Arithmetic_Sequence_Sources))]
        public void Calculate_Aseq_Returns_One_For_Arithmetic_Sequence(int[] sequence)
        {
            int expected = 1;

            int actual = _sut.Calculate(Operation.Aseq, sequence);

            Assert.That(actual, Is.EqualTo(expected));
        }

        private IEnumerable<int[]> Calculate_Aseq_Returns_Zero_For_Not_Arithmetic_Sequence_Sources
        {
            get
            {
                yield return new[] { 10, 8, 4, 1, -2, -5, -8 };
                yield return new[] { 42, 42, 42, 43, 42 };
                yield return new[] { 1, 2, 3, 4, 13 };
            }
        }

        [Test]
        [TestCaseSource(nameof(Calculate_Aseq_Returns_Zero_For_Not_Arithmetic_Sequence_Sources))]
        public void Calculate_Aseq_Returns_Zero_For_Not_Arithmetic_Sequence(int[] sequence)
        {
            int expected = 0;

            int actual = _sut.Calculate(Operation.Aseq, sequence);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}