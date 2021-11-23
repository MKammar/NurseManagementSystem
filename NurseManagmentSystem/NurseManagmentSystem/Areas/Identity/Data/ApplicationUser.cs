using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NurseManagmentSystem.Models;

namespace NurseManagmentSystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Patient> patients { get; set; }
        public ICollection<Device> devices { get; set; }
        public ICollection<NotificationApplicationUser> notificationApplicationUsers { get; set; }
    }
}
