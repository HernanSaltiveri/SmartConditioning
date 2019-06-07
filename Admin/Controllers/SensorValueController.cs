using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Admin.ViewModels;
using Admin.Data.Repositories;
using Admin.Data.Interfaces;
using Admin.Models;

namespace Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorValueController : Controller
    {
        // GET api/values/5
        //[HttpGet]
        ////[ApiExplorerSettings(IgnoreApi = true)]
        //public IEnumerable<string> SendValues(Measurement measurement)
        //{
        //    return new string[] { "sucess" };
        //}

        [HttpGet]
        //[ApiExplorerSettings(IgnoreApi = true)]
        public IEnumerable<string> Get()
        {
            return new string[] { "sucess" };
        }
    }
}