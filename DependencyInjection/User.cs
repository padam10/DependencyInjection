using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
   public class User
   {
       private INotificationService _notificationService;

       public string UserName { get; set; }

        public User(string username,INotificationService notification)
        {
            UserName = username;
            _notificationService = notification;
        }

        public void changeUsername(string newUsername)
        {
            UserName = newUsername;
            _notificationService.notifyUserNameChanged(this);
            
        }
    }
}
