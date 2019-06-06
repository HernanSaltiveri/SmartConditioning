using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Admin.ViewModels;
using Admin.Data.Repositories;
using Admin.Data.Interfaces;

namespace Admin.Controllers
{
    public class ApiController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> SendValues(string temperature, string airhumidity, string carbonmonoxide, string healthstatus)
        {
            return "value";
        }
    }
}
