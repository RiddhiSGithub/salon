using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project.Admin
{
    public partial class showAppointments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id"] == null)
            {
                Response.Redirect("https://localhost:44399/Authentication/Login.aspx");
            }


            Classes.BookAppointment appointment = new Classes.BookAppointment();
            grdDisplayAppointments.DataSource = appointment.showAppointments();
            grdDisplayAppointments.DataBind();
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44399/Authentication/Login.aspx");
        }
    }
}