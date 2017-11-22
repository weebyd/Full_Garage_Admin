using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Account
    {
        public long ID { get; set; }
        public string Username { get; set; }
        public int GarageID { get; set; }
        public int RoleID { get; set; }
    }
}