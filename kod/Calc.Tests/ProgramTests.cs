using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Main_Returns_IntMin_When_Null_Args()
        {
            // arrange
            int expected = int.MinValue;
            //Application sut = new Application();

            // act
            int actual = Program.Main(null);

            // assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Main_Returns_IntMin_When_Empty_Args()
        {
            int expected = int.MinValue;

            // act
            int actual = Program.Main(new string[] { });

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Main_Returns_IntMin_When_First_Arg_Not_sum_Or_product()
        {
            int expected = int.MinValue;

            // act
            int actual = Program.Main(new[] { "limes" });

            Assert.AreEqual(actual, expected);
        }
    }
}