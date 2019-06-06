using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Data.Interfaces;

namespace Admin.Data.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly SmartConditioningDbContext _appDbContext;
        public DeviceRepository(SmartConditioningDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Device> Devices => _appDbContext.Devices;
    }
}
