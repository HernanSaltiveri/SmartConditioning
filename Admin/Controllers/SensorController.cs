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
        private readonly IDeviceRepository _deviceRepository;

        public SensorController(ISensorRepository sensorRepository, IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
            _sensorRepository = sensorRepository;
        }
        public IActionResult Index(int? id)
        {
            var vm = new SensorListViewModel()
            {
                Sensors = _sensorRepository.Sensors
            }; 
            return View(vm);
        }

        public IActionResult Search(int? id)
        {
            var vm = new SensorListViewModel();

            vm.Device = _deviceRepository.Devices.Where(x => x.DeviceId == id).FirstOrDefault();
            vm.Sensors = _sensorRepository.Sensors.Where(x => x.Device == vm.Device);
            
            return View(vm);
        }
    }
}