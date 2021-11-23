using CsvHelper.Configuration;
using NurseManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.Mappers
{
    public sealed class HeartRateMapper : ClassMap<HeartRate>
    {
        public HeartRateMapper()
        {
            Map(x => x.HR).Name("HR");
        }
    }
}
