using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MySQLStoreAPI.Authentication
{
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }
}