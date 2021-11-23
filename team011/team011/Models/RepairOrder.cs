using System;
namespace team011.Models
{
    public class RepairOrder
    {
       

        public string VIN { get; set; }
        public DateTime start_date { get; set; }
        public int customerID { get; set; }
        public string repair_starter { get; set; }
        public int odometer_value { get; set; }
        public string description { get; set; }
        public decimal labor_charge { get; set; }
        public DateTime complete_date { get; set; }

        public string customer_name { get; set; }
        public decimal parts_cost { get; set; }
        public string repair_starter_name { get; set; }
        public decimal total_cost { get; set; }
    }
}
