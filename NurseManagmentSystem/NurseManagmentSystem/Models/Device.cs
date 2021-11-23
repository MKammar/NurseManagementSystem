using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.Models
{
    public class Device
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        public string name { get; set; }
        
        [Required(ErrorMessage = "Please enter serial number")]
        public string serialNumber { get; set; } 
        public string nurseId { get; set; }
       
    }
}
