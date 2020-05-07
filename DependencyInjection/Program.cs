using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var notficationService = new NotificationService();
            var user = new User("Padam",notficationService);
            user.changeUsername("Adam");
            Console.ReadLine();
        }
    }
}
