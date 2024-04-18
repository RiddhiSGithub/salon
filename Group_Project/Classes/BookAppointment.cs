using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Web;

namespace Group_Project.Classes
{
    public delegate bool bookNewAppointment();
    public class BookAppointment
    {
        int custId;
        DateTime appDate, startTime, endTime;
        List<int> services = new List<int>();
        float totalCost = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SalonManagementSystemConnectionString1"].ConnectionString);

        public object this[string str]
        {
            get { 
                switch(str)
                {
                    case "appDate":
                        return appDate;

                    case "startTime":
                        return startTime;

                    case "endTime":
                        return endTime;

                    case "custId":
                        return custId;

                    case "services":
                        return services;

                    default: return null;
                }
            }

            set {
                switch (str)
                {
                    case "appDate":
                        appDate = (DateTime)value;
                        break;

                    case "startTime":
                        startTime = (DateTime)value;
                        break;

                    case "endTime":
                        endTime = (DateTime)value;
                        break;

                    case "custId":
                        custId = (int)value; 
                        break;

                    case "services":
                         services = (List<int>)value;
                        break;
                    
                }
            }
        }

        public bool bookAppointment()
        {
            bool isBooked = false;

            try
            {
                TimeSpan totaltime = TimeSpan.Zero;

                //assigning all the data context
                ServicesDataContext dtService = new ServicesDataContext(con);
                BookAppointmentDataContext dtApp = new BookAppointmentDataContext(con);

                Tbl_Appointment_Master master = new Tbl_Appointment_Master();
                Tbl_Appointment_Details detail = new Tbl_Appointment_Details();
                Tbl_Services tbl_Services = new Tbl_Services();


                //calculating total time
                foreach(int val in services)
                {
                    var serviceDetails = from s in dtService.Tbl_Services
                                      where s.service_id == val
                                      select s;
                    
                    foreach(var item in serviceDetails)
                    {
                        totaltime += item.service_time_span;
                        totalCost += float.Parse(item.service_price.ToString());
                    }
                    
                }

                //calculating start time;                
                int count = dtApp.Tbl_Appointment_Masters.Count(x=> x.app_start_time.TimeOfDay == new TimeSpan(9,0,0) && x.app_date == appDate);               
                
                if(count == 0 ) {
                    startTime = DateTime.Parse("09:00:00");
                }
                else
                {
                    startTime = dtApp.Tbl_Appointment_Masters.Where(x=> x.app_date == appDate).Max(x => x.app_end_time) ;                    
                    
                }

                endTime = startTime + totaltime;

                master.app_date = appDate;
                master.app_start_time = startTime;
                master.app_end_time = endTime;
                master.cust_id = custId;
                master.app_total_cost = totalCost;
                master.app_status = 'P';

                dtApp.Tbl_Appointment_Masters.InsertOnSubmit(master);
                dtApp.SubmitChanges();

                if(master.app_id > 0)
                {
                    foreach(int val in services)
                    {
                        detail = new Tbl_Appointment_Details();
                        detail.app_id_master = master.app_id;
                        detail.service_id = val;
                        dtApp.Tbl_Appointment_Details.InsertOnSubmit(detail);
                        dtApp.SubmitChanges();
                    }

                    

                    if(detail.app_id > 0)
                    {
                        isBooked = true;
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return isBooked;
        }

        public DataTable showAppointments()
        {
            DataTable dtAppointments = new DataTable();
            SqlCommand cmd = new SqlCommand("select master.cust_id 'cust_id', cust.cust_name 'cust_name', cust.cust_email 'cust_email', cust.cust_contact 'cust_contact', CONCAT(DATEPART(day, master.app_date), ' ', DATENAME(month,master.app_date), ', ',YEAR(master.app_date)) 'app_date', concat(master.app_total_cost,'$') 'total_cost', CONVERT(VARCHAR(10), CAST(master.app_start_time AS TIME), 0) 'start_time', CONVERT(VARCHAR(10), CAST(master.app_end_time AS TIME), 0) 'end_time' from Tbl_Appointment_Master master inner join Tbl_Customer_Details cust on master.cust_id = cust.cust_id", con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dtAppointments);

            return dtAppointments;
        }

        public DataTable myApps(int id)
        {
            DataTable dtAppointments = new DataTable();
            SqlCommand cmd = new SqlCommand($"select master.cust_id 'cust_id', cust.cust_name 'cust_name', cust.cust_email 'cust_email', cust.cust_contact 'cust_contact', CONCAT(DATEPART(day, master.app_date), ' ', DATENAME(month,master.app_date), ', ',YEAR(master.app_date)) 'app_date', concat(master.app_total_cost,'$') 'total_cost', CONVERT(VARCHAR(10), CAST(master.app_start_time AS TIME), 0) 'start_time', CONVERT(VARCHAR(10), CAST(master.app_end_time AS TIME), 0) 'end_time' from Tbl_Appointment_Master master inner join Tbl_Customer_Details cust on master.cust_id = cust.cust_id where cust.cust_id = {id}", con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dtAppointments);

            return dtAppointments;
        }
    }
}