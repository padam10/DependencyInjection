﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface INotificationService
    {
        void notifyUserNameChanged(User user);
    }
}
