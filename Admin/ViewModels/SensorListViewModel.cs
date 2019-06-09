using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Data.Interfaces;

namespace Admin.ViewModels
{
    public class SensorListViewModel
    {
        public Device Device { get; set; }
        public IEnumerable<Sensor> Sensors { get; set; }
        public IEnumerable<Sensor> SensorItems { get; set; }

        //Build the Sensor Items - Todo
        public void getSensorItems()
        {

        }

        
    }
}
