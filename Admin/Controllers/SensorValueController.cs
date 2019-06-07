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

        [HttpGet]
        [Route("Ping")]
        //To Do Handle the Api
        public IEnumerable<string> Get()
        {
            return new string[] { "sucess" };
        }

        [HttpPost]
        [Route("AddMeasurement")]
        public void Post_AddMeasurements(List<Measurement> _measurements)
        {
        }


    }
}