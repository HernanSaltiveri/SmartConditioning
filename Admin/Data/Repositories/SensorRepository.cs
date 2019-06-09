using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Data.Interfaces;
using Admin.ViewModels;
using System.Data;//.Entity;

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

        //public IEnumerable<Sensor> Sensors() {
        //    var rtn = _appDbContext.Sensors;
        //    return rtn;// _appDbContext.Sensors;
        //}

        //public IEnumerable<Sensor> SensorsByDeviceId(int deviceId)
        //{
        //    var rtn = _appDbContext.Sensors;
        //    foreach (var sensor in rtn)
        //    {
        //        sensor.Device = _appDbContext.Devices.Where(x => x.DeviceId == deviceId);
        //    }

        //    return rtn;// _appDbContext.Sensors;
        //}

        //public IEnumerable<SensorListViewModel> GetSensors => null;

        //public IEnumerable<SensorListViewModel> GetSensors()
        //{
        //    _appDbContext.Database.sql
        //    return _appDbContext.Database.SqlQuery<SensorListViewModel>(
        //    "SELECT Puzzles.Name AS PuzzleName, UserProgresses.Minute, " +
        //    "UserProgresses.Session FROM UserProgresses " +
        //    "INNER JOIN Puzzles ON Puzzles.Id = UserProgresses.PuzzleId " +
        //    "WHERE UserProgresses.UserId = @userid", new SqlParameter("@userid", userId)).ToList();
        //}
    }
}
