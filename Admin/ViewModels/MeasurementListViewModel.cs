using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;

namespace Admin.ViewModels
{
    public class MeasurementListViewModel
    {
        public IEnumerable<Measurement> Measurements { get; set; }
    }
}
