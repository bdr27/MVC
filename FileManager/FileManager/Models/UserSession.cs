using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileManager.Models
{
    public class UserSession
    {
        public int userID { set; get; }
        public string username { set; get; }
        public int userType { set; get; }
    }
}