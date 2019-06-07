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
    public class SensorController : Controller
    {
        private readonly ISensorRepository _sensorRepository;
        public SensorController(ISensorRepository sensorRepository)
        {
            _sensorRepository = sensorRepository;
        }
        public IActionResult Index()
        {
            var vm = new SensorListViewModel()
            {
                Sensors = _sensorRepository.Sensors
            }; 
            return View(vm);
        }
    }
}