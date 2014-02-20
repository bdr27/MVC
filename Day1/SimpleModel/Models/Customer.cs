using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleModel.Models
{
    public class Customer
    {
        private string _Code;
        private string _Name;
        private double _Amount;

        public string Code
        {
            set
            {
                _Code = value;
            }
            get
            {
                return _Code;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public double Amount
        {
            set
            {
                _Amount = value;
            }
            get
            {
                return _Amount;
            }
        }
    }
}