using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Logic.NumberExtenion;

namespace Logic.Tests
{
    [TestClass]
    public class NumberExtenionTests
    {
        [TestMethod]
        public void FindNearWrapper_12_ReturnTrue()
        {
            int input = 12;
            string expected = "21";
            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearWrapper_513_ReturnTrue()
        {
            int input = 513;
            string expected = "531";
            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearWrapper_2017_ReturnTrue()
        {
            int input = 2017;
            string expected = "2071";
            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearWrapper_414_ReturnTrue()
        {
            int input = 414;
            string expected = "441";
            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearWrapper_144_ReturnTrue()
        {
            int input = 144;
            string expected = "414";
            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearWrapper_1234321_ReturnTrue()
        {
            int input = 1234321;
            string expected = "1241233";
            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearWrapper_1234126_ReturnTrue()
        {
            int input = 1234126;
            string expected = "1234162";
            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearWrapper_3456432_ReturnTrue()
        {
            int input = 3456432;
            string expected = "3462345";
            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindNearWrapper_10_ReturnMinusOne()
        {
            int input = 10;
            string expected = "-1";


            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindNearWrapper_20_ReturnMinusOne()
        {
            int input = 20;
            string expected = "-1";

            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);

        }
    }
}
