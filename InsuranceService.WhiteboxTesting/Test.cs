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
        public void test1()
        {

        }
    }
}