using _16._7.Practice;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._7.PracticeTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(200, 10) == 210);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(200, 10) == 190);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(20, 10) == 200);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }

        [Test]
        public void Division_MustThrowException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(20, 0));
        }
    }
}
