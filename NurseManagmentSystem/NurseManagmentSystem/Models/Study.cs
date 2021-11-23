using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.Models
{
    public class Study
    {
        [Key]
        public int id { get; set; }
        public int patientId { get; set; }
        public Patient patient { get; set; }
        public int deviceId { get; set; }
        public Device device { get; set; }
        [Required(ErrorMessage = "Please enter Start Time")]
        public DateTime startTime { get; set; }
        [Required(ErrorMessage = "Please enter Duration")]
        public int duration { get; set; }
        
        public ICollection<HeartRate> heartRates { get; set; }
        public ICollection<Comment> comments { get; set; }
    }
}
