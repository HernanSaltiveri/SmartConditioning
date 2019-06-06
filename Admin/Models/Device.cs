using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Device
    {
        public int DeviceId { get; set; }

        public string serialNumber { get; set; }
        public DateTime registrationDate { get; set; }
        public string firmWareVersion { get; set; }

        public List<Measurement> Measurements { get; set; }
    }
}
