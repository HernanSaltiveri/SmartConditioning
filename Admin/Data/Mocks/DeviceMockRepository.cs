using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Data.Interfaces;
using Admin.Models;

namespace Admin.Data.Mocks
{

    public class DeviceMockRepository : IDeviceRepository
    {
        public IEnumerable<Device> Devices
        {
            get
            {
                return new List<Device>
                     {
                         new Device {  DeviceId = 1, firmWareVersion = "v1.0", serialNumber="12312313", registrationDate = DateTime.Now},
                         new Device {  DeviceId = 2, firmWareVersion = "v2.0", serialNumber="23463634", registrationDate = DateTime.Now}
                     };
            }
        }
    }
}
