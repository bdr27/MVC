using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleModel.Models
{
    public class Customer
    {
        public int ID { set; get; }
        public string CustomerCode { set; get; }
        public double Amount { get; set; }
    }
}