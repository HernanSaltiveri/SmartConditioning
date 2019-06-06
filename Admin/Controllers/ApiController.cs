using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Admin.ViewModels;
using Admin.Data.Repositories;
using Admin.Data.Interfaces;

using Admin.Models;

namespace Admin.Controllers
{
    public class ApiController : Controller
    {
        // GET api/values/5
        [HttpGet()]
        public ActionResult<string> SendValues(Measurement measurement)
        {
            return "sucess";
        }

        public string Index()
        {
            
            return "";
        }
    }
}
