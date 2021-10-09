using FirstApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstApp
{
    public partial class About : Page
    {
        MyContext myContext;
        protected void Page_Load(object sender, EventArgs e)
        {
             myContext = new MyContext();
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            string name = NameText.Text;
            string surname = SurnameText.Text;

            Student student = new Student()
            {
                Name = name,
                Surname = surname
            };
            myContext.Students.Add(student);

            myContext.SaveChanges();

            NameText.Text = "";
            SurnameText.Text = string.Empty;
        }
    }
}