using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetcodeTraining.Tests
{
    [TestClass]
    public class ReverseBits_Tests
    {
        [TestMethod]
        public void From_1010_Should_Return_0101()
        {
            uint reversedBits = 0b0101U << 28;

            Assert.AreEqual(reversedBits, ReverseBitsSolution.ReverseBits((uint)10));
        }

        [TestMethod]
        public void From_10011011_Should_Return_11011001()
        {
            uint reversedBits = 0b11011001U << 24;

            Assert.AreEqual(reversedBits, ReverseBitsSolution.ReverseBits(0b10011011));
        }

        [TestMethod]
        public void From_1111_Should_Return_1111()
        {
            uint reversedBits = 0b1111U << 28;

            Assert.AreEqual(reversedBits, ReverseBitsSolution.ReverseBits(0b1111));
        }
    }
}
