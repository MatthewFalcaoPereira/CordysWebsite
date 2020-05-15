using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CordysWebsite.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CordysWebsite.Controllers
{
    public class RecordsController : Controller
    {
        // GET: Records
        public ActionResult Index(Properties prop)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string string1 = "Select * from [dbo].[mvcUserReg]";
            SqlCommand sqlcomm = new SqlCommand(string1);
            sqlcomm.Connection = sqlconn;
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            List<Properties> objmodel = new List<Properties>();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    var details = new Properties();
                    details.StoreName = sdr["Name"].ToString();
                    details.Product = sdr["Product"].ToString();
                    details.Address = sdr["Address"].ToString();
                    details.Tel = sdr.GetInt32(3);
                    details.Price = sdr.GetDecimal(3);
                    details.Quantity = sdr.GetInt32(3);
                    objmodel.Add(details);
                }
                prop.SalesAmount = objmodel;
                sqlconn.Close();
            }
            return View("Index",prop);
        }
    }
}