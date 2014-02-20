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
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayCustomer()
        {
            Customer objCustomer = new Customer();
            objCustomer.Code = Request.Form["CustomerCode"];
            objCustomer.Name = Request.Form["CustomerName"];
            objCustomer.Amount = Convert.ToDouble(Request.Form["CustomerAmount"].ToString());

            return View("DisplayCustomer", objCustomer);
        }

        public ActionResult FillCustomer()
        {
            return View();
        }
    }
}
