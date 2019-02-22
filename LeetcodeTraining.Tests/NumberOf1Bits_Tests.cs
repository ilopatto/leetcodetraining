using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LeetcodeTraining.Tests
{
    [TestClass]
    public class NumberOf1Bits_Tests
    {
        [TestMethod]
        public void Should_Return_2()
        {
            Assert.AreEqual(2, NumberOf1BitsSolution.HammingWeight(0b1010));
        }

        [TestMethod]
        public void Should_Return_32()
        {
            Assert.AreEqual(32, NumberOf1BitsSolution.HammingWeight(uint.MaxValue));
        }

        [TestMethod]
        public void Should_Return_0()
        {
            Assert.AreEqual(0, NumberOf1BitsSolution.HammingWeight(0));
        }
    }
}
