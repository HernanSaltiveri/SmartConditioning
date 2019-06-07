using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;

namespace Admin.ViewModels
{
    public class SensorItemViewModel
    {
        public Device Device { get; set; }
        public Sensor Sensor { get; set; }
    }
}
