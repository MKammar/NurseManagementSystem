using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.Models
{
    public class Patient
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Please enter fullname")]
        public string fullname { get; set; }
        [EmailAddress(ErrorMessage ="Please enter valid email")]
        public string email { get; set; }
        public string phonenumber { get; set; }
        [Required(ErrorMessage = "Please enter age")]
        public int age { get; set; }
        [Required(ErrorMessage = "Please enter gender")]
        public string gender { get; set; }
        public string nurseId { get; set; }

        public ICollection<Study> studies { get; set; }
    }
}
