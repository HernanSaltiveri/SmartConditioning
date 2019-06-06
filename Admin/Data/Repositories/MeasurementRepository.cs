using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Data.Interfaces;

namespace Admin.Data.Repositories
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public MeasurementRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Measurement> Measurements => _appDbContext.Measurements;
    }
}
