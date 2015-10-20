using System.Collections.Generic;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public partial class CalculatorTests
    {
        [Test]
        public void Calculate_Ndec_Returns_One_When_There_Are_No_Arguments()
        {
            int expected = 1;

            int actual = _sut.Calculate(Operation.Ndec, new int[] { });

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Ndec_Returns_One_When_There_Is_Only_One_Argument()
        {
            int expected = 1;

            int actual = _sut.Calculate(Operation.Ndec, new[] { 5 });

            Assert.That(actual, Is.EqualTo(expected));
        }

        private IEnumerable<int[]> Calculate_Ndec_Returns_One_For_Non_Decreasing_Seqence_Sources
        {
            get
            {
                yield return new[] { 10, 11, 12, 15, 18, 22, 37, 45 };
                yield return new[] { 42, 42, 42, 42, 42 };
                yield return new[] { 1, 2 };
            }
        }

        [Test]
        [TestCaseSource(nameof(Calculate_Ndec_Returns_One_For_Non_Decreasing_Seqence_Sources))]
        public void Calculate_Ndec_Returns_One_For_Non_Decreasing_Seqence(int[] sequence)
        {
            int expected = 1;

            int actual = _sut.Calculate(Operation.Ndec, sequence);

            Assert.That(actual, Is.EqualTo(expected));
        }

        private IEnumerable<int[]> Calculate_Ndec_Returns_Zero_For_Decreasing_Sequence_Sources
        {
            get
            {
                yield return new[] { 10, 11, 12, 13, 14, 13, 12, 11 };
                yield return new[] { 42, 42, 42, 41, 41 };
                yield return new[] { 1, 0 };
            }
        }

        [Test]
        [TestCaseSource(nameof(Calculate_Ndec_Returns_Zero_For_Decreasing_Sequence_Sources))]
        public void Calculate_Ndec_Returns_Zero_For_Decreasing_Sequence(int[] sequence)
        {
            int expected = 0;

            int actual = _sut.Calculate(Operation.Ndec, sequence);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}