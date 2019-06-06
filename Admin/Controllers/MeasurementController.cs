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
    public class MeasurementController : Controller
    {
        private readonly IMeasurementRepository _measurementRepository;
        public MeasurementController(IMeasurementRepository measurementRepository)
        {
            _measurementRepository = measurementRepository;
        }
        public IActionResult Index()
        {
            var vm = new MeasurementListViewModel()
            {
                Measurements = _measurementRepository.Measurements
            }; 
            return View(vm);
        }
    }
}