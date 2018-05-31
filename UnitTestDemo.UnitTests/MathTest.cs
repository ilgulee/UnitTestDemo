using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Math = UnitTestDemo.Fundamentals.Math;

namespace UnitTestDemo.UnitTests
{
    [TestFixture]
    public class MathTest
    {
        private Math _math;

        //SetUp
        [SetUp]
        public void SetUp()
        {
            _math=new Math();
        }
        //TearDown


        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result=_math.Add(1, 2);
            Assert.That(result,Is.EqualTo(3));
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);
            Assert.That(result,Is.EqualTo(expected));
        }

        [Test]
        [Ignore("Because parameterized tests are implemened.")]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Because parameterized tests are implemened.")]
        public void Max_TwoArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
