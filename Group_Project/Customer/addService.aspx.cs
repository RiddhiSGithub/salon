using Group_Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project.Customer
{
    public partial class addService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("https://localhost:44399/Authentication/Login.aspx");
            }
        }

        protected void btnAddService_Click(object sender, EventArgs e)
        {
            Classes.Services services = new Classes.Services();
            addNewService add = new addNewService(services.addService);

            TimeSpan time_span = TimeSpan.Parse(txtTimeSpan.Text);
            services["name"] = txtName.Text;
            services["time"] = time_span;
            services["price"] = float.Parse(txtCost.Text);

            if (add())
            {
                lblMessage.Text = "Service Added Successfully";
            }
            else
            {
                lblMessage.Text = "Service not added";
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44399/Authentication/Login.aspx");
        }
    }
}