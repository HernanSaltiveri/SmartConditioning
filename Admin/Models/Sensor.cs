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

        //Could measure one or multiple values. In the last case the type value should have the value multiple
        public string Type { get; set; }

        public virtual List<Measurement> Measurements { get; set; }
        public virtual Device Device { get; set; }

    }
}
