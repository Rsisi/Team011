using System;
namespace team011.Models
{
    public class Monthly_Sales_Report
    {
        public DateTime year { get; set; }

        public DateTime month { get; set; }
        public int totalVehicleSold { get; set; }
        public decimal totalNetIncome { get; set; }
        public decimal SalesIncome { get; set; }
        public decimal Ratio { get; set; }

       
    }
}
