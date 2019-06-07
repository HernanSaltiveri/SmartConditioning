using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public string sensorSerialNumber { get; set; }

        public List<Measurement> Measurements { get; set; }
        public virtual Device Device { get; set; }

    }
}
