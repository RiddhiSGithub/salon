
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Xml.Linq;

namespace Group_Project.Classes
{
    public delegate bool addNewService();

    internal class Services
    {
        int id;
        string name;
        TimeSpan time_span;
        float price;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SalonManagementSystemConnectionString1"].ConnectionString);

        public object this[string str]
        {
            get
            {
                switch (str)
                {
                    case "id":
                        return id;

                    case "name":
                        return name;

                    case "time":
                        return time_span;

                    case "price":
                        return price;

                        default: return null;
                }
            }

            set
            {
                switch (str)
                {
                    case "id":
                        id = (int)value;
                        break;

                    case "name":
                        name = (string)value;
                        break;


                    case "time":
                        time_span = (TimeSpan)value;
                        break;

                    case "price":
                        price = (float)value;
                        break;

                    
                }
            }
        }

        public bool addService()
        {
            bool isAdded = false;

            ServicesDataContext dt = new ServicesDataContext(con);
            Tbl_Services services = new Tbl_Services();
            services.service_name = name;
            services.service_price = price;
            services.service_time_span = time_span;

            dt.Tbl_Services.InsertOnSubmit(services);
            dt.SubmitChanges();

            if(services.service_id != 0)
            {
                isAdded = true;
            }

            return isAdded;
        }
    
        public DataTable showAllServices()
        {
            ServicesDataContext services = new ServicesDataContext(con);            

            Table<Tbl_Services> table = services.GetTable<Tbl_Services>();
            List<Tbl_Services> rows = table.ToList();

            DataTable dataTable = new DataTable();
            PropertyInfo[] properties = typeof(Tbl_Services).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }

            foreach (Tbl_Services row in rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (PropertyInfo property in properties)
                {
                    dataRow[property.Name] = property.GetValue(row, null);
                }
                dataTable.Rows.Add(dataRow);
            }      
            

            return dataTable;  
        }

        
    }
}