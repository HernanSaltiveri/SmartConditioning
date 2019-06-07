﻿using System;
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
        private readonly ISensorRepository _sensorRepository;
        public MeasurementController(IMeasurementRepository measurementRepository, ISensorRepository sensorRepository)
        {
            _measurementRepository = measurementRepository;
            _sensorRepository = sensorRepository;
                
        }
        public IActionResult Index()
        {
            var vm = new MeasurementListViewModel()
            {
                Measurements = _measurementRepository.Measurements
            }; 
            return View(vm);
        }
        public IActionResult Search(int? id)
        {
            var vm = new MeasurementListViewModel();

            vm.Sensor = _sensorRepository.Sensors.Where(x => x.SensorId == id).FirstOrDefault();
            vm.Measurements = _measurementRepository.Measurements.Where(x => x.Sensor == vm.Sensor);

            return View(vm);
        }
    }
}