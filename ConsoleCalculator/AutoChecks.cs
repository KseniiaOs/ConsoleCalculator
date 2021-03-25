using NUnit.Framework;
using ConsoleCalculator;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-5, Minus.SubtractOfTwoIntegers(0, 5));
            Assert.AreEqual(5, Minus.SubtractOfTwoIntegers(10, 5));
        }
    }
}