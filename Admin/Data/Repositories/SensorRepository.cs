using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Data.Interfaces;

namespace Admin.Data.Repositories
{
    public class SensorRepository : ISensorRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public SensorRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Sensor> Sensors => _appDbContext.Sensors;
    }
}
