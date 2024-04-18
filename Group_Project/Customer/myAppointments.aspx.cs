﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project.Customer
{
    public partial class myAppointments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id"] == null)
            {
                Response.Redirect("https://localhost:44399/Authentication/Login.aspx");
            }

            if (Session["id"] == null)
            {
                btnLogOut.Text = "Login/Register";
                btn.Text = "";
            }
            else
            {
                btnLogOut.Text = "Logout";
                btn.Text = "My appointments";
            }

            Classes.BookAppointment bookAppointment = new Classes.BookAppointment();
            grdDisplayAppointments.DataSource = bookAppointment.myApps(Convert.ToInt32(Session["id"]));
            grdDisplayAppointments.DataBind();
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            if (btnLogOut.Text.Equals("Login/Register"))
            {
                Response.Redirect("https://localhost:44399/Authentication/Login.aspx");
            }
            else
            {
                btnLogOut.Text = "Login/Register";
                Session["id"] = null;
                Response.Redirect("https://localhost:44399/Customer/index.aspx");
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("myAppointments.aspx");
        }
    }
}