using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_App
{
    public partial class CalculatePremium : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected float Calculate(int age, string gender)
        {
            Assignment.InsuranceService SUT = new Assignment.InsuranceService();
            float result;

            result = SUT.CalcPremium(age, gender);
            return result;
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            float result;
            int age = int.Parse(TextBox1.Text);
            string gender = TextBox2.Text;
            result = Calculate(age, gender);

            Label1.Text = result.ToString();
            Label1.Visible = true;
        }
    }
}