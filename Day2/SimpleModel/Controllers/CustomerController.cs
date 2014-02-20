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
        List<Customer> customers = new List<Customer>();

        public CustomerController()
        {
            var obj1 = new Customer();
        }
        //
        // GET: /Customer/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayCustomer(int id)
        {
            Customer objCustomer = new Customer();
            objCustomer.CustomerCode = Request.Form["CustomerCode"];
            objCustomer.ID = Convert.ToInt32(Request.Form["CustomerID"]);
            objCustomer.Amount = Convert.ToDouble(Request.Form["CustomerAmount"].ToString());

            return View("DisplayCustomer", objCustomer);
        }

        public ActionResult FillCustomer()
        {
            return View();
        }
    }
}
