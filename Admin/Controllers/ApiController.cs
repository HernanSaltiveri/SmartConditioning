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
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        // GET api/values/5
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public ActionResult<string> SendValues(Measurement measurement)
        {
            return "sucess";
        }

       
    }
}
