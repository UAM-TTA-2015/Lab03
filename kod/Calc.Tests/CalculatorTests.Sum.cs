using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public partial class CalculatorTests
    {
        [Test]
        public void Calculate_Sum_Returns_Zero_When_There_Are_No_Arguments()
        {
            int expected = 0;

            int actual = _sut.Calculate(Operation.Sum, new int[] { });

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Sum_Returns_Sum_Of_All_Remaining_Arguments()
        {
            int[] arguments = { 2, 4, 6 };
            int expected = 12;

            int actual = _sut.Calculate(Operation.Sum, arguments);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}