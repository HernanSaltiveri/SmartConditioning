using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Data.Interfaces;
using Admin.Models;

namespace Admin.Data.Mocks
{

    public class MeasurementMockRepository : IMeasurementRepository
    {
        public IEnumerable<Measurement> Measurements
        {
            get
            {
                return new List<Measurement>
                     {
                         new Measurement {  AirHumidity = 100},
                         new Measurement {  AirHumidity = 200}
                     };
            }
        }
    }
}
