using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Admin.ViewModels;
using Admin.Data.Repositories;
using Admin.Data.Interfaces;
using Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace Admin.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceRepository _deviceRepository;
        public DeviceController(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        [Authorize]
        public IActionResult Index(int? serialNumber)
        {
            var vm = new DeviceListViewModel();
            //{
            //    Devices = _deviceRepository.Devices
            //};

            if (serialNumber == null){
                vm.Devices = _deviceRepository.Devices;
            }
            else {
                vm.Devices = _deviceRepository.Devices.Where(x => x.serialNumber== serialNumber.ToString());
            }
            return View(vm);
        }
        [Authorize]
        public IActionResult Search(int? id)
        {
            var vm = new DeviceListViewModel();
           
            if (id == null)
            {
                vm.Devices = _deviceRepository.Devices;
            }
            else
            {
                vm.Devices = _deviceRepository.Devices.Where(x => x.serialNumber == id.ToString());
            }

            return View(vm);
        }


        public IActionResult Create()
        {
            var vm = new Device();
            return View(vm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeviceId,serialNumber")] Device device)//([Bind("EmployeeId,FullName,EmpCode,Position,OfficeLocation")] Employee employee)
        {
            //if (ModelState.IsValid)
            //{
            //    if (employee.EmployeeId == 0)
            //        _context.Add(employee);
            //    else
            //        _context.Update(employee);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(employee);
            return View();
        }
    }
}