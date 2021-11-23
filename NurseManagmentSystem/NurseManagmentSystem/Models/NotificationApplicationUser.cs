using NurseManagmentSystem.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.Models
{
    public class NotificationApplicationUser
    {
        [Key]
        public int id { get; set; }
        public int notificationId { get; set; }
        public Notification notification { get; set; }
        public string userId { get; set; }
        public ApplicationUser user { get; set; }
        public Boolean isRead { get; set; } = false;
    }
}
