using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace team011.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult LookupCustomerForm()
        {


            ViewBag.customer= "this is look up ustomer view";
            return View();
        }
        public IActionResult AddCustomerForm()
        {
            //ViewBag.addcustomer = "this is add ustomer view";
            return View();
        }
    }
}
