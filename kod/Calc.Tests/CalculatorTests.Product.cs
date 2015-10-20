using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public partial class CalculatorTests
    {
        [Test]
        public void Calculate_Product_Returns_One_When_There_Are_No_Arguments()
        {
            int expected = 1;

            int actual = _sut.Calculate(Operation.Product, new int[] { });

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Product_Returns_Product_Of_All_Remaining_Arguments()
        {
            int[] arguments = { 2, 5, 3 };
            int expected = 30;

            int actual = _sut.Calculate(Operation.Product, arguments);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}