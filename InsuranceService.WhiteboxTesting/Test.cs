using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment;

namespace InsuranceService.WhiteboxTesting
{
    [TestFixture]
    class Test
    {
        public Assignment.InsuranceService SUT;

        [SetUp]
        public void initialize()
        {
            SUT = new Assignment.InsuranceService();
        }

        [Test]
        public void Test_01()
        {
            float result = SUT.CalcPremium(18, "female");
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test_02()
        {
            float result = SUT.CalcPremium(50, "female");
            Assert.That(result, Is.EqualTo(0.375));
        }

        [Test]
        public void Test_03()
        {
            float result = SUT.CalcPremium(31, "female");
            Assert.That(result, Is.EqualTo(2.5));
        }

        [Test]
        public void Test_04()
        {
            float result = SUT.CalcPremium(15, "female");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_05()
        {
            float result = SUT.CalcPremium(18, "male");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Test_06()
        {
            float result = SUT.CalcPremium(50, "male");
            Assert.That(result, Is.EqualTo(0.75));
        }

        [Test]
        public void Test_07()
        {
            float result = SUT.CalcPremium(36, "male");
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test_08()
        {
            float result = SUT.CalcPremium(15, "male");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_09()
        {
            float result = SUT.CalcPremium(25, "orange");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_10()
        {
            float result = SUT.CalcPremium(50, "orange");
            Assert.That(result, Is.EqualTo(0));
        }
    }
}