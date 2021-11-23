using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NurseManagmentSystem.DAL.Contracts;
using NurseManagmentSystem.Models;

namespace NurseManagmentSystem.Controllers
{
    public class NotificationController : Controller
    {
        IRepositoryBase<Notification> _notifications;
        IRepositoryBase<NotificationApplicationUser> _notificationsApplicationUsers;

        public NotificationController(IRepositoryBase<Notification> notifications , IRepositoryBase<NotificationApplicationUser> notificationsApplicationUsers)
        {
            _notifications = notifications;
            _notificationsApplicationUsers = notificationsApplicationUsers;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetNotification()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var notification = _notificationsApplicationUsers.GetNotifications(userId);

            /*List<Notification> notificationList = new List<Notification>();
            foreach( var n in notification)
            {
                notificationList.Add(n.notification);
            }
            Debug.WriteLine(notification[0].notification.id + " x " + notification[0].notification.message);*/
            
            return Ok(new { userNotification = notification, count = notification.Count });
        }

        public IActionResult ReadNotification(int notificationId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _notificationsApplicationUsers.ReadNotification(notificationId, userId);

            return Ok();
        }
    }
}
