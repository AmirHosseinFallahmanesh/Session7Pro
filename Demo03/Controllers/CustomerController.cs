using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo03.Controllers
{
    [Controller]
    public class Customer
    {
        public string Index()
        {
            return "Customer Page";
        }
    }
}