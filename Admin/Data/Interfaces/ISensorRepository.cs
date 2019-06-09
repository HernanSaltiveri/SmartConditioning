using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.ViewModels;

namespace Admin.Data.Interfaces
{
    public interface ISensorRepository
    {
        IEnumerable<Sensor> Sensors { get; }

        //IEnumerable<SensorListViewModel> GetSensors { get; }
    }
}
