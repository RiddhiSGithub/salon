using Group_Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Group_Project.Authentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Classes.Authentication auth = new Classes.Authentication();
            auth["email"] = username;
            auth["password"] = password;

            loginUser login = new loginUser(auth.login);
            int id = login();
            if (id > 0)
            {
                Session["id"] = id;
                Response.Redirect("https://localhost:44399/Customer/index.aspx");
            }
            else if(username.Equals("admin@gmail.com") && password.Equals("admin123"))
            {
                Session["id"] = -1;
                Response.Redirect("https://localhost:44399/Admin/showAppointments.aspx");
            }
            else
            {
                

                lblMessage.Text = "Username or password is incorrect";
            }
        }
    }
}