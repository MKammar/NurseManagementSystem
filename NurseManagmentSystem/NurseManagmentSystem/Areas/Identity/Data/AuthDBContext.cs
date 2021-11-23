using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NurseManagmentSystem.Areas.Identity.Data;
using NurseManagmentSystem.Models;

namespace NurseManagmentSystem.Data
{
    public class AuthDBContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDBContext(DbContextOptions<AuthDBContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> patients { get; set; }
        public DbSet<Device> devices { get; set; }
        public DbSet<Study> studies { get; set; }
        public DbSet<HeartRate> heartRates { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Notification> notifications { get; set; }
        public DbSet<NotificationApplicationUser> notificationsApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            
        }
    }
}
