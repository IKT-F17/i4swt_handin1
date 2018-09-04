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
        public Calculator uut; // <-- Member variable kunne også være private.
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        
        // Add Test
        [Test]
        public void Add_Add2And4_Returns6()
        {
            Assert.That(uut.Add(2,4), Is.EqualTo(6));
        }

        // Subtract Test
        [Test]
        public void Sub_Sub5from9_Returns4()
        {
            Assert.That(uut.Subtract(9, 5), Is.EqualTo(4));
        }

        // Multiply Test
        [Test]
        public void Mul_Mul2and5_Returns10()
        {
            Assert.That(uut.Multiply(2,5), Is.EqualTo(10));
        }

        // Power Test
        [Test]
        public void Pow_Pow2and2_Returns4()
        {
            Assert.That(uut.Power(2, 2), Is.EqualTo(4));
        }
    }

  
}
