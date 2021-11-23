
using NurseManagmentSystem.Data;
using NurseManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.DAL.Repositories
{
    public class DeviceRepository : RepositoryBase<Device>
    {
        internal AuthDBContext _applicationContext;
        public DeviceRepository(AuthDBContext context)
           : base(context)
        {
            if (context == null)
                throw new ArgumentException("Database context is not defined.");
            _applicationContext = context;
        }

        override
        public  List<Device> GetFiltered()
        {
            var devices = _applicationContext.devices.Where(d => !_applicationContext.studies.Select(s => s.deviceId).Contains(d.id)).ToList();
            return devices;
        }

        override
        public  bool UniqueData(string value)
        {
            var device = _applicationContext.devices.Where(d => d.serialNumber == value).FirstOrDefault();
            if(device == null)
            {
                return true;
            }

            return false;
        }
    }
}
