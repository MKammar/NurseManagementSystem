using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.Models
{
    public class Notification
    {
        [Key]
        public int id { get; set; }
        public string message { get; set; }
        public ICollection<NotificationApplicationUser> notificationApplicationUsers { get; set; }
    }
}
