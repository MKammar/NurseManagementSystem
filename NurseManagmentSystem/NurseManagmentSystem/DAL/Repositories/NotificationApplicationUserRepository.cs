using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NurseManagmentSystem.Data;
using NurseManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.DAL.Repositories
{
    public class NotificationApplicationUserRepository : RepositoryBase<NotificationApplicationUser>
    {
        internal AuthDBContext _applicationContext;
        public NotificationApplicationUserRepository(AuthDBContext context)
           : base(context)
        {
            if (context == null)
                throw new ArgumentException("Database context is not defined.");
            _applicationContext = context;
           
        }
        override
        public List<NotificationApplicationUser> GetNotifications(string userId)
        {
            var l = _applicationContext.notificationsApplicationUsers.Where(u => u.userId == userId).Where(u => u.isRead == false).Include(n => n.notification).ToList();
            return l;
        }

        override
        public void ReadNotification(int notificationId, string userId)
        {
            var notification = _applicationContext.notificationsApplicationUsers
                                        .FirstOrDefault(n => n.userId.Equals(userId)
                                        && n.notificationId == notificationId);
            

            notification.isRead = true;
            _applicationContext.notificationsApplicationUsers.Update(notification);
            _applicationContext.SaveChanges();
        }
    }
   
}
