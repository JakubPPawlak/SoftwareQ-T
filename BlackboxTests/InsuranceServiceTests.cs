using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using fit.Fixtures;
using Assignment;

namespace BlackboxTests
{
    public class InsuranceServiceTests : ColumnFixture
    {
        public static InsuranceService insurance;
        public static int age;
        public static string gender;

        public float premium()
        {
            insurance = new InsuranceService();

            return insurance.CalcPremium(age, gender);
        }
    }
}

