using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using team011.Helper;
using team011.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace team011.Controllers
{
    public class VehicleController : Controller
    {
        // GET: /<controller>/
        public IActionResult VehicleDetailForm(string VIN)
        {
            
            SqlCommand cmd;
            SqlConnection cnn;
            SqlDataReader reader;
            var vehicle = new Vehicle();          
            var customer = new Customer();
            vehicle.isSold = false;
            customer.isIndividual = false;
            vehicle.isSold = false;

            cnn = ConnectionHelper.openConnection();


            
            //sql command
            var vehicleETEsql = "WITH VehicleCTE AS( SELECT v.VIN, description, model_year, model_name, " +
                "invoice_price,manufacturer_name , inv_writer_user_name, add_date,  'Car' as vehicle_type " +
                "FROM Vehicle v INNER JOIN Car c on  v.VIN = c.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name, add_date, " +
                "'Convertible' FROM Vehicle v INNER JOIN Convertible c on  v.VIN = c.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name," +
                "add_date, 'Truck' FROM Vehicle v INNER JOIN Truck t on  v.VIN = t.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name, " +
                "add_date, 'Van' FROM Vehicle v INNER JOIN Van  on  v.VIN = Van.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name, " +
                "add_date, 'SUV' FROM Vehicle v INNER JOIN SUV s  on  v.VIN = s.VIN )";
            var selectsql = "SELECT VehicleHasColor.VIN, vehicle_type, model_year, manufacturer_name, " +
                "model_name, description, invoice_price, invoice_price * 1.25 as list_price, first_name, last_name, add_date, " +
                "STRING_AGG(color, ',') AS vehicle_color, "+
                "number_of_doors, roof_type, back_seat_count, cargo_capacity, cargo_cover_type, number_of_rear_axies, has_driver_side_back_door, number_of_cupholder, drivetrain_type "+
                "FROM VehicleCTE INNER JOIN VehicleHasColor " +
                "on VehicleCTE.VIN = VehicleHasColor.VIN INNER JOIN Users on Users.user_name=inv_writer_user_name "+
                "LEFT JOIN Car on VehicleCTE.VIN=Car.VIN LEFT JOIN Convertible on VehicleCTE.VIN=Convertible.VIN LEFT JOIN Truck on VehicleCTE.VIN=Truck.VIN "+
                "LEFT JOIN Van on VehicleCTE.VIN=Van.VIN LEFT JOIN SUV on VehicleCTE.VIN=SUV.VIN "+
                "WHERE VehicleCTE.VIN = @vin " +
                "GROUP by VehicleHasColor.VIN, vehicle_type, model_year, manufacturer_name, model_name, description, invoice_price, invoice_price * 1.25,first_name, last_name, add_date, number_of_doors, roof_type, back_seat_count, cargo_capacity, cargo_cover_type, number_of_rear_axies, has_driver_side_back_door, number_of_cupholder, drivetrain_type ";

            var sql = vehicleETEsql + selectsql;
            cnn = ConnectionHelper.openConnection();
            cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@vin", VIN);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                {
                while (reader.Read())
                {
                    vehicle.VIN = (string)reader["VIN"];
                    vehicle.vehicle_type = (string)reader["vehicle_type"];
                    vehicle.model_year = (int)reader["model_year"];
                    vehicle.manufacturer_name = (string)reader["manufacturer_name"];
                    vehicle.model_name = (string)reader["model_name"];
                    vehicle.invoice_price = (decimal)reader["invoice_price"];
                    vehicle.list_price = decimal.Round((decimal)reader["list_price"], 2, MidpointRounding.AwayFromZero);
                    vehicle.first_name = (string)reader["first_name"];
                    vehicle.last_name = (string)reader["last_name"];
                    vehicle.add_date = (DateTime)reader["add_date"];
                    vehicle.vehicle_color = reader["vehicle_color"] != DBNull.Value ? (string)reader["vehicle_color"] : "";
                    vehicle.description = reader["description"] != DBNull.Value ? (string)reader["description"] : "";

                    if (vehicle.vehicle_type == "Car")
                    {
                        vehicle.number_of_doors = (int)reader["number_of_doors"];

                    }
                    else if (vehicle.vehicle_type == "Convertible")
                    {
                        vehicle.roof_type = (string)reader["roof_type"];
                        vehicle.back_seat_count = (int)reader["back_seat_count"];
                    }
                    else if (vehicle.vehicle_type == "Truck")
                    {
                        vehicle.cargo_capacity = (decimal)reader["cargo_capacity"];
                        vehicle.cargo_cover_type = (string)reader["cargo_cover_type"];
                        vehicle.number_of_rear_axies = (int)reader["number_of_rear_axies"];
                    }
                    else if (vehicle.vehicle_type == "Van")
                    {
                        vehicle.has_driver_side_back_door = (bool)reader["has_driver_side_back_door"];

                    }
                    else if (vehicle.vehicle_type == "SUV")
                    {
                        vehicle.number_of_cupholder = (int)reader["number_of_cupholder"];
                        vehicle.drivetrain_type = (string)reader["drivetrain_type"];
                    }
                }
                }
                

            var buyersql = "SELECT SalesTransaction.customerID, email, phone_number, street_address, city, state, postal_code, " +
                "sold_price, sales_writer_user_name, sold_price, transaction_date, U.first_name AS uf, U.last_name AS ul, " +
                "I.first_name as Indf, I.last_name as Indl, B.business_name, B.contact_name, B.contact_title "+
                "FROM SalesTransaction, Users AS U JOIN SalesPeople AS S on U.user_name=S.user_name, Customer AS C " +
                "LEFT JOIN Individual AS I on C.customerID=I.customerID LEFT JOIN Business AS B on C.customerID=B.customerID " +
                "WHERE SalesTransaction.VIN = @vin AND SalesTransaction.CustomerID = C.customerID " +
                "AND SalesTransaction.sales_writer_user_name=U.user_name;";
            cnn = ConnectionHelper.openConnection();
            cmd = new SqlCommand(buyersql, cnn);
            cmd.Parameters.AddWithValue("@vin", VIN);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                {
                vehicle.isSold = true;
                    while (reader.Read())
                    {
                    customer.customerID = (int)reader["customerID"];
                    customer.email = reader["email"] != DBNull.Value ? (string)reader["email"] : "";
                    customer.phone_number = (string)reader["phone_number"];
                    customer.street_address = (string)reader["street_address"];
                    customer.city = (string)reader["city"];
                    customer.state = (string)reader["state"];
                    customer.postal_code = (string)reader["postal_code"];
                    if(reader["business_name"] != DBNull.Value)
                    {
                        customer.isIndividual = false;
                        customer.business_name = (string)reader["business_name"];
                        customer.contact_name = (string)reader["contact_name"];
                        customer.contact_title= (string)reader["contact_title"];
                    }
                    else
                    {
                        customer.isIndividual = true;
                        customer.first_name = (string)reader["Indf"];
                        customer.last_name = (string)reader["Indl"];
                    
                    }


                    vehicle.sold_price = (decimal)reader["sold_price"];
                    vehicle.sold_date = (DateTime)reader["transaction_date"];
                    vehicle.sales_people_name = (string)reader["uf"] + ", " + (string)reader["ul"];

                    }
                }

            var repairHistorys = new List<RepairOrder>();
            var repairHistorySQL = "SELECT B.business_name, I.first_name, I.last_name, R.start_date, complete_date, labor_charge, parts_cost, R.repair_starter, U.first_name AS uf, U.last_name AS ul " +
                "FROM Customer AS C LEFT OUTER JOIN Individual AS I on C.customerID=I.customerID  LEFT OUTER JOIN Business AS B on C.customerID=B.customerID, " +
                "RepairDetails AS R LEFT JOIN " +
                "(SELECT VIN, start_date, SUM (quantity*price) AS parts_cost FROM Part GROUP BY Part.VIN, Part.start_date) AS P " +
                "ON (R.start_date= P.start_date AND R.VIN=P.VIN) "+
                "JOIN USERS as U on R.repair_starter=U.user_name "+
                "WHERE R.customerID = C.customerID AND R.VIN = @vin AND R.complete_date IS NOT NULL " +
                "ORDER BY R.start_date DESC, R.complete_date ASC; ";
              
            cmd = new SqlCommand(repairHistorySQL, cnn);
            cmd.Parameters.AddWithValue("@vin", VIN);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                vehicle.isRepaired = true;
                while (reader.Read())
                {
                    var repairHistory = new RepairOrder();
                    var bn = reader["business_name"] != DBNull.Value ? (string)reader["business_name"] : "";
                    var fn = reader["first_name"] != DBNull.Value ? (string)reader["first_name"] : "";
                    var ln = reader["last_name"] != DBNull.Value ? (string)reader["last_name"] : "";
                    repairHistory.customer_name = bn + fn + " " + ln;
                    repairHistory.repair_starter_name = (string)reader["uf"] + " " + (string)reader["ul"];
                    repairHistory.start_date = (DateTime)reader["start_date"];
                    repairHistory.complete_date = (DateTime)reader["complete_date"];
                    repairHistory.labor_charge = (decimal)reader["labor_charge"];
                    repairHistory.parts_cost = reader["parts_cost"] != DBNull.Value ? (decimal)reader["parts_cost"] : 0;
                    repairHistory.total_cost = repairHistory.labor_charge + repairHistory.parts_cost;
                    repairHistorys.Add(repairHistory);

                }
            }

            ViewBag.repairHistorys = repairHistorys;
            ViewBag.vehicle = vehicle;
                ViewBag.customer = customer;

            //close sql connection
            ConnectionHelper.closeConnection(cnn, cmd, reader);





            return View();
            
            //ViewBag.vehicle = "vehicle Detail for VIN:" + VIN;
            //ViewBag.VIN = VIN;
            //return View();
        }

        //POST AddVehicleForm
        public IActionResult AddVehicleForm()
        {
            SqlCommand cmd;
            SqlConnection cnn;
            SqlDataReader reader;
            cnn = ConnectionHelper.openConnection();

          
            //get all colors
            var allcolors = new List<Color>();
            var allColorsql = "SELECT name FROM Color";
            cmd = new SqlCommand(allColorsql, cnn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var color = new Color();
                color.name = (string)reader["name"];
                allcolors.Add(color);

                ViewBag.allcolors = new MultiSelectList(allcolors, "name", "name");
            }
            //get all manufacturer
            var allmanufacturer = new List<Manufacturer>();
            var manufacturersql = "SELECT name FROM Manufacturer;";
            cmd = new SqlCommand(manufacturersql, cnn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var manufacturer = new Manufacturer();
                manufacturer.name = (string)reader["name"];
                allmanufacturer.Add(manufacturer);

                ViewBag.allmanufacturer = new SelectList(allmanufacturer, "name", "name");
            }

            //close sql connection
            ConnectionHelper.closeConnection(cnn, cmd, reader);

            //get current year
            ViewBag.currentYear= DateTime.Now.Year;



            //all vehicle types
            var alltypes = new List<SelectListItem>()
            {
                new SelectListItem{ Value = "VAN" , Text="VAN"},
                new SelectListItem{ Value = "Truck" , Text="Truck"},
                new SelectListItem{ Value = "SUV" , Text="SUV"},
                new SelectListItem{ Value = "Car" , Text="Car"},
                new SelectListItem{ Value = "Convertible" , Text="Convertible"},
            };
            ViewBag.alltypes = new SelectList(alltypes, "Value", "Text");

            return View();
        }

        public JsonResult searchVehicleByFeature(string color,string manufacture,string type,string year,string model, string keyword) {

            SqlCommand cmd;
            SqlConnection cnn;
            SqlDataReader reader;
            var vehicles =  new List<Vehicle>();

            var vehicleETEsql = "WITH VehicleCTE AS( SELECT v.VIN, description, model_year, model_name, " +
                "invoice_price,manufacturer_name , inv_writer_user_name, add_date,  'Car' as vehicle_type " +
                "FROM Vehicle v INNER JOIN Car c on  v.VIN = c.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name, add_date, " +
                "'Convertible' FROM Vehicle v INNER JOIN Convertible c on  v.VIN = c.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name," +
                "add_date, 'Truck' FROM Vehicle v INNER JOIN Truck t on  v.VIN = t.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name, " +
                "add_date, 'Van' FROM Vehicle v INNER JOIN Van  on  v.VIN = Van.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name, " +
                "add_date, 'SUV' FROM Vehicle v INNER JOIN SUV s  on  v.VIN = s.VIN )";
            var selectsql = "SELECT VehicleHasColor.VIN, vehicle_type, model_year, manufacturer_name, " +
                "model_name, description, invoice_price * 1.25 as list_price, " +
                "STRING_AGG(color, ',') AS vehicle_color FROM VehicleCTE INNER JOIN VehicleHasColor " +
                "on VehicleCTE.VIN = VehicleHasColor.VIN WHERE 1=1 ";
            if(color != null)
            {
                selectsql += " AND VehicleHasColor.color = '" + color + "'";
            }
            if(model != null)
            {
                selectsql += " AND VehicleCTE.model_name = '" + model + "'";
            }
            if(manufacture != null)
            {
                selectsql += " AND VehicleCTE.manufacturer_name = '" + manufacture + "'";
            }
            if (type != null)
            {
                selectsql += " AND VehicleCTE.vehicle_type =  '"+ type + "'";
            }
            if (year != null)
            {
                selectsql += " AND VehicleCTE.model_year =  '" + year + "'";
            }
            if(keyword != null)
            {
                selectsql += " AND (model_year LIKE '%"+ keyword+ "%' OR model_name LIKE '%" + keyword + "%' OR description LIKE '%" + keyword + "%') ";
            }



            selectsql += " GROUP by VehicleHasColor.VIN, vehicle_type, model_year, manufacturer_name, model_name, description, invoice_price * 1.25";

            var sql = vehicleETEsql + selectsql;
            cnn = ConnectionHelper.openConnection();
            cmd = new SqlCommand(sql, cnn);
           
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var vehicle = new Vehicle();
                vehicle.VIN = (string)reader["VIN"];
                vehicle.vehicle_type = (string)reader["vehicle_type"];
                vehicle.model_year = (int)reader["model_year"]; 
                vehicle.manufacturer_name = (string)reader["manufacturer_name"];
                vehicle.model_name = (string)reader["model_name"];
                vehicle.list_price = (decimal)reader["list_price"];
                vehicle.vehicle_color = reader["vehicle_color"] != DBNull.Value ? (string)reader["vehicle_color"] : "";
                vehicle.description = reader["description"] != DBNull.Value ? (string)reader["description"] : "";

                vehicles.Add(vehicle);


            }
            ConnectionHelper.closeConnection(cnn, cmd, reader);
            return Json(vehicles);

        }

        public JsonResult searchVehicleByVIN(string vin)
        {
            SqlCommand cmd;
            SqlConnection cnn;
            SqlDataReader reader;
            var vehicles = new List<Vehicle>();

            var vehicleETEsql = "WITH VehicleCTE AS( SELECT v.VIN, description, model_year, model_name, " +
                "invoice_price,manufacturer_name , inv_writer_user_name, add_date,  'Car' as vehicle_type " +
                "FROM Vehicle v INNER JOIN Car c on  v.VIN = c.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name, add_date, " +
                "'Convertible' FROM Vehicle v INNER JOIN Convertible c on  v.VIN = c.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name," +
                "add_date, 'Truck' FROM Vehicle v INNER JOIN Truck t on  v.VIN = t.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name, " +
                "add_date, 'Van' FROM Vehicle v INNER JOIN Van  on  v.VIN = Van.VIN " +
                "UNION " +
                "SELECT v.VIN, description, model_year, model_name, invoice_price,manufacturer_name , inv_writer_user_name, " +
                "add_date, 'SUV' FROM Vehicle v INNER JOIN SUV s  on  v.VIN = s.VIN )";
            var selectsql = "SELECT VehicleHasColor.VIN, vehicle_type, model_year, manufacturer_name, " +
                "model_name, description, invoice_price * 1.25 as list_price, " +
                "STRING_AGG(color, ',') AS vehicle_color FROM VehicleCTE INNER JOIN VehicleHasColor " +
                "on VehicleCTE.VIN = VehicleHasColor.VIN WHERE VehicleCTE.VIN = @vin " +
                "GROUP by VehicleHasColor.VIN, vehicle_type, model_year, manufacturer_name, model_name, description, invoice_price * 1.25";

            var sql = vehicleETEsql + selectsql;
            cnn = ConnectionHelper.openConnection();
            cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@vin", vin);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var vehicle = new Vehicle();
                vehicle.VIN = (string)reader["VIN"];
                vehicle.vehicle_type = (string)reader["vehicle_type"];
                vehicle.model_year = (int)reader["model_year"];
                vehicle.manufacturer_name = (string)reader["manufacturer_name"];
                vehicle.model_name = (string)reader["model_name"];
                vehicle.list_price = (decimal)reader["list_price"];
                vehicle.vehicle_color = (string)reader["vehicle_color"];
                vehicle.description = reader["description"] != DBNull.Value ? (string)reader["description"] : "";

                vehicles.Add(vehicle);


            }
            ConnectionHelper.closeConnection(cnn, cmd, reader);
            return Json(vehicles);

        }
    }
}
