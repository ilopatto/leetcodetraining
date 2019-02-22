using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTraining.Tests
{
    [TestClass]
    public class ReverseInt_Tests
    {
        [TestMethod]
        public void Number_123_Should_Become_321()
        {
            Assert.AreEqual(321, ReverseIntSolution.ReverseInt(123));
        }

        [TestMethod]
        public void Number_1234567899_Should_Become_0()
        {
            Assert.AreEqual(0, ReverseIntSolution.ReverseInt(1234567899));
        }
        
    }
}
