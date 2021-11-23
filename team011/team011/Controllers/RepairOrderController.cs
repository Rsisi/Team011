using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using team011.Helper;
using team011.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace team011.Controllers
{
    public class RepairOrderController : Controller
    {
        // GET: /<controller>/
        public IActionResult NewRepairForm()
        {
            ViewBag.repair = "This is start new repair order view";
            return View();
        }
        public IActionResult UpdateRepairForm()
        {
            ViewBag.updaterepair = "This is update  repair order view";
            return View();
        }
        public IActionResult Index(string VIN = "WBALY1C5XED787278")
        {




            return View();
        }

        public JsonResult SearchOrderByVIN(string VIN)
        {
            SqlCommand cmd;
            SqlConnection cnn;
            SqlDataReader reader;
            var repairOrder = new RepairOrder();
            var hasOpenOrder = false;

            cnn = ConnectionHelper.openConnection();
            var checkOpenRepairOrdersql = "Select * from RepairDetails r inner join Customer c on r.customerID = c.customerID " +

                "inner join Users u on u.user_name = r.repair_starter "+
                "where vin  = @vin and complete_date is not null ";
            //sql command
            cmd = new SqlCommand(checkOpenRepairOrdersql, cnn);
            cmd.Parameters.AddWithValue("@vin", VIN);
            //read resutlt
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                hasOpenOrder = true;
                while (reader.Read())
                {
                    repairOrder.complete_date = (DateTime)reader["complete_date"];
                    repairOrder.labor_charge = reader["labor_charge"] != DBNull.Value ? (decimal)reader["labor_charge"] : 0;
                    repairOrder.description = reader["description"] != DBNull.Value ? (string)reader["description"] : null;
                    repairOrder.VIN = (string)reader["VIN"];
                    repairOrder.customerID = (int)reader["customerID"];
                    repairOrder.repair_starter = (string)reader["repair_starter"];
                    repairOrder.odometer_value = (int)reader["odometer_value"];
                    repairOrder.start_date = DateTime.Parse(reader["start_date"].ToString());
                    repairOrder.repair_starter_name = (string)reader["first_name"] + " " + (string)reader["last_name"];

                }
            }
            ViewData["hasOpenOrder"] = hasOpenOrder;
            ViewBag.repairOrder = repairOrder;

            var parts = new List<Part>();
            var partSQL = "Select * from part where vin = @vin";
            cmd = new SqlCommand(partSQL, cnn);
            cmd.Parameters.AddWithValue("@vin", VIN);
            reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                var part = new Part();
                part.quantity = (int)reader["quantity"];
                part.start_date = (DateTime)reader["start_date"];
                part.part_number = (string)reader["part_number"];
                part.price = (decimal)reader["price"];
                part.vendor = (string)reader["vendor"];
                parts.Add(part);

            }
            ViewBag.Parts = parts;
            ConnectionHelper.closeConnection(cnn, cmd, reader);
            return Json(new { hasOpenOrder = hasOpenOrder, repairOrder = repairOrder, parts = parts });
        }
        [HttpPost]
        //updagte repair order info
        public JsonResult UpdateRepairOrder(double laborcharge, string description, string VIN, string start_date)
        {
            SqlCommand cmd;
            SqlConnection cnn;

            cnn = ConnectionHelper.openConnection();
            var updatelaborchargesql = "update RepairDetails set labor_charge =@laborcharge, description = @description " +
                " where VIN =@VIN and start_date =@start_date ";
            //sql command
            cmd = new SqlCommand(updatelaborchargesql, cnn);
            var date = DateTime.Parse(start_date);
            cmd.Parameters.AddWithValue("@VIN", VIN);
            cmd.Parameters.AddWithValue("@laborcharge", laborcharge);
            cmd.Parameters.AddWithValue("@start_date", DateTime.Parse(start_date));
            cmd.Parameters.AddWithValue("@description", description);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cnn.Close();

            return Json(true);
        }

        public JsonResult AddPart(List<Part> parts)
        {

            SqlCommand cmd;
            SqlConnection cnn;

            cnn = ConnectionHelper.openConnection();
            foreach(var p in parts)
            {
                var addpartsql = "Insert into Part Values( @VIN, @start_date, @part_number, " +
               " @quantity, @price,@vendor)";
                //sql command
                cmd = new SqlCommand(addpartsql, cnn);

                cmd.Parameters.AddWithValue("@VIN", p.VIN);
                cmd.Parameters.AddWithValue("@part_number", p.part_number);
                cmd.Parameters.AddWithValue("@start_date", p.start_date);
                cmd.Parameters.AddWithValue("@quantity", p.quantity);
                cmd.Parameters.AddWithValue("@price", p.price);
                cmd.Parameters.AddWithValue("@vendor", p.vendor);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }


            cnn.Close();

            return Json(true);

        }


    }
}
