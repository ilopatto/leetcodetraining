using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LeetcodeTraining.Tests
{
    [TestClass]
    public class RemoveDuplicates_Tests
    {
        [TestMethod]
        public void Should_Return_2()
        {
            var source = new int[] { 1,1,2 };
            var result = new int[2];

            Assert.AreEqual(2, RemoveDuplicatesSolution.RemoveDuplicates(source));
            Array.Copy(source, result, 2);

            CollectionAssert.AreEqual(new int[] { 1, 2 }, result);
        }

        [TestMethod]
        public void Should_Return_5()
        {
            var source = new int[] { 0, 1, 1, 2, 2, 2, 2, 3, 4 };
            var result = new int[5];

            Assert.AreEqual(5, RemoveDuplicatesSolution.RemoveDuplicates(source));
            Array.Copy(source, result, 5);

            CollectionAssert.AreEqual(new int[] { 0, 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void Should_Return_4_Without_Modyfying()
        {
            var source = new int[] { 1, 2, 3, 4 };
            var result = new int[4];

            Assert.AreEqual(4, RemoveDuplicatesSolution.RemoveDuplicates(source));
            Array.Copy(source, result, 4);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, result);
        }

    }
}
