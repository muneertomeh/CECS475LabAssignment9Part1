using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CECS475LabAssignment9Part1.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [TestCategory("Add")]
        [Ignore]
        public void AddSimple()
        {
            //
            Calculator calc = new Calculator();
            int summation = calc.Add(1,2);
            Assert.AreEqual(3,summation);
        }


        [TestMethod]
        [TestCategory("Divide")]
        public void DivideSimple()
        {
            Calculator calc = new Calculator();
            int quotient = calc.Divide(10,5);
            Assert.AreEqual(2, quotient);
        }

        [TestMethod]
        [TestCategory("Divide")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero()
        {
            Calculator calc = new Calculator();
            int quotient = calc.Divide(10, 0);
            
        }
    }
}
