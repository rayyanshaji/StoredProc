using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoredProc.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace StoredProc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PurchaseModel pd = new PurchaseModel();
            return View(pd);
        }

        [HttpPost]
        public IActionResult Index(int purchaseOrderId)
        {
     
            DataSet ds = new DataSet();
            /*CONNECTION STRING*/
            String procname = "GetTransactDetails";
            String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(constring);
            sqlcon.Open();
            /*SQL QUERY */
            SqlCommand sqlcom = new SqlCommand(procname, sqlcon); //connection

            sqlcom.CommandType = CommandType.StoredProcedure; //stored procedure
            sqlcom.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId); 

            //GRIDVIEW
            SqlDataReader dt = sqlcom.ExecuteReader();
            PurchaseModel pd = new PurchaseModel();
            //FILL DATA TABLES WITH DATA FROM SQL DATABASE
            if (dt.Read() && ModelState.IsValid)
            {
                
                pd.PurchaseOrderId = purchaseOrderId;
                pd.LineNumber = Convert.ToInt32(dt["LineNumber"].ToString());
                pd.UnitPrice = Convert.ToDouble(dt["UnitPrice"].ToString());
                pd.ProductID = Convert.ToInt32(dt["ProductID"].ToString());
                pd.OrderQty = Convert.ToInt32(dt["ProductID"].ToString());
                pd.ReceivedQty = Convert.ToInt32(dt["ProductID"].ToString());
                pd.RejectedQty = Convert.ToInt32(dt["ProductID"].ToString());
                pd.DueDate = Convert.ToDateTime(dt["DueDate"].ToString());

            } else
            {
                pd.PurchaseOrderId = null;
                pd.LineNumber = null;
                pd.ProductID = null;
                pd.UnitPrice = null;
                pd.OrderQty = null;
                pd.ReceivedQty = null;
                pd.RejectedQty = null;
                pd.DueDate = null;
            }

            sqlcon.Close();
            return View(pd);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
