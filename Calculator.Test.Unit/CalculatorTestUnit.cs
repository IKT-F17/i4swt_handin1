using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Group 7 (Frederik, John, Mark og Tonni)")]
    public class CalculatorTestUnit
    {
        private Calculator _uut;

    // Test Setup:
        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

    // Add Test
        [TestCase(2.1, 8.1, 10.2)]
        [TestCase(-2.1, 8.1, 6)]
        [TestCase(2.1, -8.1, -6)]
        [TestCase(-2.1, -8.1, -10.2)]
        public void Add_Test(double a, double b, double result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

    // Subtract Test:
        [TestCase(10.1, 5.8, 10.1-5.8)]
        [TestCase(-10.1, 5.8, -10.1-5.8)]
        [TestCase(10.1, -5.8, 10.1-(-5.8))]
        [TestCase(-10.1, -5.8, (-10.1)-(-5.8))]
        public void Subtract_Test(double a, double b, double result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

    // Multiply Test:
        [TestCase(7.2, 2.4, 17.28)]
        [TestCase(-7.2, 2.4, -17.28)]
        [TestCase(7.2, -2.4, -17.28)]
        [TestCase(-7.2, -2.4, 17.28)]
        public void Multiply_Test(double a, double b, double result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

    // Divide Test:
        [TestCase(10.1, 2.5, 4.04)]
        [TestCase(-10.1, 2.5, -4.04)]
        [TestCase(10.1, -2.5, -4.04)]
        [TestCase(-10.1, -2.5, 4.04)]
        public void Divide_Test(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));
        }
    
    // Divide by zero Test:
        [Test]
        public void Divide_DivideByZeroException()
        {
            Assert.That(() => _uut.Divide(10, 0), Throws.TypeOf<DivideByZeroException>());
        }

    // Power Test:
        [TestCase(2.5, 2.0, 6.25)]
        [TestCase(-2.5, 2.0, 6.25)]
        [TestCase(2.5, -2.0, 0.16)]
        [TestCase(-2.5, -2.0, 0.16)]
        //[TestCase(0.40, 3.0, 0.064)]
        //[TestCase(-0.40, 3.0, -0.064)]
        //[TestCase(0.40, -3.0, 15.625)]
        //[TestCase(-0.40, -3.0, -15.625)]
        public void Power_Test(double a, double b, double result)
        {
            Assert.That(_uut.Power(a, b), Is.EqualTo(result));
        }
    }
}
