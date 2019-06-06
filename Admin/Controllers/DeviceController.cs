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
    public class DeviceController : Controller
    {

        private readonly IDeviceRepository _deviceRepository;

        public DeviceController(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }


        public IActionResult Index()
        {
            var vm = new DeviceListViewModel()
            {
                Devices = _deviceRepository.Devices
            }; 
            return View(vm);
        }
    }
}