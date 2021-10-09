using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstApp
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            //Label1.Text = "Hello World";
            int number1 =Convert.ToInt32( Number1TextBox.Text);
            int number2 =Convert.ToInt32( Number2TextBox.Text);

            ResultTextBox.Text = (number1 + number2).ToString();
        }
    }
}