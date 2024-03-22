using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpNew;

namespace UnitTestProject
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void VerifyAdditonMethod()
        {

            Assert.AreEqual(calculator.Addition(10, 20), 30);

        }

        [TestMethod]
        public void VerifyMultiplicationMethod()
        {
            Assert.AreEqual(calculator.Multiplication(10, 20), 200);
        }
    }
}
