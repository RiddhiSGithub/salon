using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Group_Project.Classes
{

    public delegate bool registerUser();
    public delegate int loginUser();
    public class Authentication
    {
        string name = null;
        string city = null ;
        char gender;
        string email = null;
        string password = null;
        Int64 contact = 0;        
        int id = 0 ;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SalonManagementSystemConnectionString1"].ConnectionString);
        
        public Authentication() {
        }

        public object this[object str]
        {
            get
            {
                switch (str)
                {

                    case "id":
                        return id;
                    case "name":
                        return name;
                        

                    case "gender":
                        return gender;
                        

                    case "city":
                        return city;

                    case "email":
                        return email;

                    case "contact":
                        return contact;

                    case "password":
                        return password;

                     

                    default:
                        return null;
                        
                }
            }

        set
            {
                switch (str)
                {
                    case "name":
                        name = (string)value;
                        break;

                    case "id":
                        id = (int)value;
                        break;

                    case "gender":
                        gender = (char)value;
                        break;


                    case "city":
                        city = (string)value;
                        break;

                    case "email":
                        email = (string)value;
                        break;

                    case "contact":
                        contact = (Int64)value;
                        break;

                    case "password":
                        password = (string)value;
                        break;

                    

                }
            }
        }

        public bool register()
        {
            bool isRegistered = false;

            try
            {
                
                CustomerRegistrationDataContext dt = new CustomerRegistrationDataContext(con);
                Tbl_Customer_Details customer = new Tbl_Customer_Details();
                customer.cust_name = name;
                customer.cust_city = city;
                customer.cust_email = email;
                customer.cust_contact = contact;
                customer.cust_gender = gender;
                customer.password = password;

                dt.Tbl_Customer_Details.InsertOnSubmit(customer);
                dt.SubmitChanges();

                if(customer.cust_id > 0)
                {
                    isRegistered = true;
                }


                

            }catch(Exception ex)
            {
                Console.WriteLine($"Registration errors : \n {ex}");
            }

            return isRegistered;
        }

        public bool isRegistered(string email)
        {
            CustomerRegistrationDataContext dt = new CustomerRegistrationDataContext(con);

            int count = dt.Tbl_Customer_Details.Count(x => x.cust_email == email);

            if (count > 0)
            {
                return true;
            }

            return false;
        }

        public int login()
        {
            int id = 0;

            CustomerRegistrationDataContext dt = new CustomerRegistrationDataContext(con);

            var data = from c in dt.Tbl_Customer_Details
                       where c.cust_email == email && c.password == password
                       select c.cust_id;

            
            if(data.Count() > 0)
            {
                foreach (var val in data)
                {
                    id = val;
                }
            }
            
            

            return id;
        }

    }
}