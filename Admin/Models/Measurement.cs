﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Measurement
    {
        public int MeasurementId { get; set; }

        public DateTime MeasumerentDateTime { get; set; }
        public double Temperature { get; set; }
        public double AirHumidity { get; set; }
        public int CarbonMonoxideLevel { get; set; }
        public string HealthStatus { get; set; }

        public virtual Sensor Sensor { get; set; }
    }
}
