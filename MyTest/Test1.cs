using _20261102_TestDemo;

namespace MyTest
{
    [TestClass]
    public sealed class CalcTest
    {
        [TestMethod]
        public void TestMethodSumWithPositiveNumbers()
        {
            int first = 5;
            int second = 10;
            int expected = 15;

            int actual = Calc.Sum(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodSumWithNegativeNumbers()
        {
            int first = -5;
            int second = -10;
            int expected = -15;

            int actual = Calc.Sum(first, second);

            Assert.AreEqual(expected, actual);
        }
    }
}
