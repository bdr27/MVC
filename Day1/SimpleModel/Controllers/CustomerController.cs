using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleModel.Models;

namespace SimpleModel.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult DisplayCustomer()
        {
            Customer objCustomer = new Customer();
            objCustomer.Code = "1001";
            objCustomer.Name = "John Smith";
            objCustomer.Amount = 200.23;

            return View("DisplayCustomer", objCustomer);
        }
    }
}
