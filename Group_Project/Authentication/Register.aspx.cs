using Group_Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Group_Project.Authentication
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rbFemale.Checked = true;    
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            char gender;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string city = txtCity.Text;
            Int64 contact = Convert.ToInt64(txtContact.Text);
            if(rbMale.Checked)
            {
                gender = 'M';
            }
            else
            {
                gender = 'F';
            }

            Classes.Authentication auth = new Classes.Authentication();
            registerUser register = auth.register;
            auth["name"] = name;
            auth["email"] = email;
            auth["password"] = password;
            auth["city"] = city;
            auth["gender"] = gender;
            auth["contact"] = contact;


            if(auth.isRegistered(email))
            {
                lblMessage.Text = "User already registerd!!";
            }
            else
            {
                if (register())
                {
                    lblMessage.Text = "User Registered Successfully";

                    txtPassword.Text = null;
                    txtCity.Text = null;
                    txtContact.Text = null;
                    txtEmail.Text = null;
                    txtName.Text = null;
                    rbMale.Checked = false;
                    rbFemale.Checked = true;
                }

                else
                {
                    lblMessage.Text = "Try again";
                }
            }

            
            
        }
    }
}