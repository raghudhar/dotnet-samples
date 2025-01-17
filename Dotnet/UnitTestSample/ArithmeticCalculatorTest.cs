﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticLibrary;

namespace UnitTestSample
{
    [TestClass]
    public class ArithmeticCalculatorTest
    {
        private ArithmeticCalculator _arithmeticCalculator;

        [TestInitialize]
        public void Initialize()
        {
            _arithmeticCalculator = new ArithmeticCalculator();
        }

        [TestMethod]
        public void PassingAdditionTest()
        {
            Assert.IsTrue(_arithmeticCalculator.Add(6, 4) == 10);
        }

        [TestMethod]
        public void FailingSubtractionTest()
        {
            Assert.IsTrue(_arithmeticCalculator.Subtract(6, 4) == 0);
        }

        [TestMethod]
        public void PassingMultiplicationTest()
        {
            Assert.IsTrue(_arithmeticCalculator.Multiply(6, 4) == 24);
        }

        [TestMethod]
        public void FailingDivisionTest()
        {
            Assert.IsTrue(_arithmeticCalculator.Divide(8, 4) == 1);
        }
    }
}
