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
        public void FindNearWrapper_1204321_ReturnTrue()
        {
            int input = 1204321;
            string expected = "1210234";
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
        public void FindNearWrapper_10_ReturnMinusOne()
        {
            int input = 10;
            string expected = "-1";


            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearWrapper_20_ReturnMinusOne()
        {
            int input = 20;
            string expected = "-1";

            string result = FindNearWrapper(input);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NewtonMethod_EvenRootOfNegativeNumber_ReturnException()
        {
            double inputNumber = -19683;
            int inputPower = 2;
            double eps = 0.000001;

            double result = NewtonMethod(inputNumber, inputPower, eps);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NewtonMethod_NegativePower_ReturnException()
        {
            double inputNumber = 83;
            int inputPower = -4;
            double eps = 0.000001;

            double result = NewtonMethod(inputNumber, inputPower, eps);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NewtonMethod_NegativeEps_ReturnException()
        {
            double inputNumber = 83;
            int inputPower = 3;
            double eps = -0.000001;

            double result = NewtonMethod(inputNumber, inputPower, eps);
        }

        [TestMethod]
        public void NewtonMethod_2of4_ReturnTrue()
        {
            double inputNumber = 4;
            int inputPower = 2;
            double eps = 0.000001;
            double expected = 2;

            double result = NewtonMethod(inputNumber, inputPower, eps);

            Assert.AreEqual(expected, result, eps);
        }

        [TestMethod]
        public void NewtonMethod_2of225_ReturnTrue()
        {
            double inputNumber = 225;
            int inputPower = 2;
            double eps = 0.000001;
            double expected = 15;

            double result = NewtonMethod(inputNumber, inputPower, eps);

            Assert.AreEqual(expected, result, eps);
        }

        [TestMethod]
        public void NewtonMethod_7of988_ReturnTrue()
        {
            double inputNumber = 988;
            int inputPower = 7;
            double eps = 0.000000001;
            double expected = 2.67807305946292;

            double result = NewtonMethod(inputNumber, inputPower, eps);

            Assert.AreEqual(expected, result, eps);
        }
    }
}
