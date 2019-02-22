using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTraining.Tests
{
    [TestClass]
    public class CountBits_Tests
    {
        [TestMethod]
        [Description("Passes 5 should return an array [0, 1, 1, 2, 1, 2]")]
        public void Pass_5()
        {
            CollectionAssert.AreEqual(
                new int[] { 0, 1, 1, 2, 1, 2 },
                CountBitsSolution.CountBits(5)
                );
        }
    }
}
