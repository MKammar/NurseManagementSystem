
using NurseManagmentSystem.Data;
using NurseManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.DAL.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>
    {
        public PatientRepository(AuthDBContext context)
            : base(context)
        {
            if (context == null)
                throw new ArgumentException("Database context is not defined.");
        }
    }
}
