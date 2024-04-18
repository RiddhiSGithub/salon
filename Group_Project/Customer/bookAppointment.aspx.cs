using Group_Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project.Customer
{
    public partial class bookAppointment : System.Web.UI.Page
    {

        List<int> services = new List<int>();
        DateTime appDate;
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


            DateTime minDate = DateTime.Today;

            
            DateTime maxDate = minDate.AddDays(7);

            
            string dateFormat = "yyyy-MM-dd";

            
            txtDate.Attributes.Add("min", minDate.ToString(dateFormat));
            txtDate.Attributes.Add("max", maxDate.ToString(dateFormat));


            if (!IsPostBack)
            {
                Classes.Services services = new Classes.Services();
                grdDisplayServices.DataSource = services.showAllServices();
                grdDisplayServices.DataBind();
            }
            
            
        }

        protected void btnBookAppointment_Click(object sender, EventArgs e)
        {
            appDate = Convert.ToDateTime(txtDate.Text);
            int count = 0;
            foreach(GridViewRow row in grdDisplayServices.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("mycheckbox");

                if (chk.Checked == true)
                {
                    int id = Convert.ToInt32(grdDisplayServices.DataKeys[row.RowIndex].Value);
                    services.Add(id);
                    count++;
                }
            }

            if(count > 0)
            {
                Classes.BookAppointment app = new Classes.BookAppointment();
                app["appDate"] = appDate;
                app["services"] = services;
                app["custId"] = Session["id"];
                bookNewAppointment newAppointment = new bookNewAppointment(app.bookAppointment);

                if (newAppointment())
                {
                    lblMessage.Text = "Appointment Booked Successfully";
                    Response.Redirect("myAppointments.aspx");
                }
                else
                {
                    lblMessage.Text = "Appointment not booked";
                }
            }
            else
            {
                lblMessage.Text = "Please select atleast 1 service !!";
            }
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