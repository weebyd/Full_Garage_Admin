using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ResponseModel
    {
        public ResponseModel()
        {

        }

        public int ResponseCode { get; set; }
        public string Message { get; set; }
        public dynamic ResponseData { get; set; }
    }
}