
using NurseManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NurseManagmentSystem.Data;

namespace NurseManagmentSystem.DAL.Repositories
{
    public class StudyRepository : RepositoryBase<Study>
    {
        internal AuthDBContext _applicationContext;

        public StudyRepository(AuthDBContext context)
           : base(context)
        {
            
            if (context == null)
                throw new ArgumentException("Database context is not defined.");

            _applicationContext = context;
        }

        override
        public  List<Study> GetAll()
        {
            var studies = _applicationContext.studies.Include(p => p.patient).Include(d => d.device).Include(h => h.heartRates).ToList();
            return studies;
        }
    }
}
