using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using NurseManagmentSystem.Areas.Identity.Data;
using NurseManagmentSystem.Data;
using NurseManagmentSystem.Infrastructure;
using NurseManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.DAL.Repositories
{
    public class NotificationRepository :RepositoryBase<Notification>
    {
        internal AuthDBContext _applicationContext;
        private UserManager<ApplicationUser> _userManager;
        private IHubContext<SignalService> _hubContext;
        public NotificationRepository(AuthDBContext context, UserManager<ApplicationUser> userManager, IHubContext<SignalService> hubContext)
           : base(context)
        {
            if (context == null)
                throw new ArgumentException("Database context is not defined.");
            _applicationContext = context;
            _userManager = userManager;
            _hubContext = hubContext;
        }

        override
        public  void Create(Notification notification)
        {
            _applicationContext.notifications.Add(notification);
            _applicationContext.SaveChanges();

            var users = _userManager.Users.ToList();
            foreach(var user in users)
            {
                var notificationuser = new NotificationApplicationUser();
                notificationuser.notificationId = notification.id;
                notificationuser.userId = user.Id;

                _applicationContext.notificationsApplicationUsers.Add(notificationuser);
                _applicationContext.SaveChanges();
            }

            _hubContext.Clients.All.SendAsync("displayNotification", "");
        }

        
    }
}
