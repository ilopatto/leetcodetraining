using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTraining.Tests
{
    [TestClass]
    public class TwoSum_Tests
    {
        [TestMethod]
        public void Should_Return_0_1()
        {
            CollectionAssert.AreEquivalent(
                new int[] { 0, 1 },
                TwoSumSolution.TwoSum(new int[] { 100, 101, 50, 51, 6, 7, 102, 99 }, 201)
                );
        }
    }
}
