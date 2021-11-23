using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.Models
{
    public class HeartRate
    {
        [Key]
        public int id { get; set; }
        public int studyId { get; set; }
        public Study study { get; set; }
        public double HR { get; set; }

    }
}
