using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class NotificationService:INotificationService
    {
        public void notifyUserNameChanged(User user)
        {
            Console.WriteLine("New Name is {0}",user.UserName);
        }
    }
}
