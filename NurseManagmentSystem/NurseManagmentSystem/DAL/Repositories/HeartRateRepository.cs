
using NurseManagmentSystem.Data;
using NurseManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.DAL.Repositories
{
    public class HeartRateRepository : RepositoryBase<HeartRate>
    {
        internal AuthDBContext _applicationContext;
        public HeartRateRepository(AuthDBContext context)
           : base(context)
        {
            if (context == null)
                throw new ArgumentException("Database context is not defined.");
            _applicationContext = context;
           
        }
       override
       public List<HeartRate> GetFilteredById(int id)
        {
            var rates = _applicationContext.heartRates.Where(r => r.studyId == id).ToList();
            return rates;
        }
    }
}
